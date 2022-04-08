using AutoMapper;
using System;
using System.Text;
using Windo.Application.Contratos;
using Windo.Application.Dtos;
using Windo.Persistence;
using Windo.Persistence.Contratos;
using Windo.Persistence.Dominio;

namespace Windo.Application;

public class LicencaService : ILicencaService{
    private readonly ILicencaPersist licencaPersist;
    private readonly IPlanoVendaPersist planoVendaPersist;
    private readonly IPlataformaPersist plataformaPersist;
    private readonly IPessoaPersist pessoaPersist;
    private readonly IGeralPersist geralPersist;
    private readonly windo_baseContext context;
    private readonly IMapper mapper;

    public LicencaService(ILicencaPersist licencaPersist, 
            IPlanoVendaPersist planoVendaPersist, 
            IPlataformaPersist plataformaPersist,
            IPessoaPersist pessoaPersist,
            IGeralPersist geralPersist,
            windo_baseContext context,
            IMapper mapper)
    {
        this.licencaPersist = licencaPersist;
        this.planoVendaPersist = planoVendaPersist;
        this.plataformaPersist = plataformaPersist;
        this.pessoaPersist = pessoaPersist;
        this.geralPersist = geralPersist;
        this.context = context;
        this.mapper = mapper;
    }
   
    public async Task<bool> AddLicencaToCliente(AddLicencaDto addLicencaDto)
    {
        var retorno = false;

        if (addLicencaDto == null) throw new ArgumentNullException();

        var planoVendaModel = await this.planoVendaPersist.GetByIdAsync(addLicencaDto.PlanoVenda);
        if(planoVendaModel == null) throw new ArgumentNullException("Plano de venda informado não é cadastrado no sistema!");  

        var dataVencimento = DateTime.Now.AddDays(planoVendaModel.ValidadeLicencaNavigation.NumeroDias);
        var valor = planoVendaModel.Valor;

        var plataformaCadastradaParaPessoa = await this.GetByPessoaIdByPlataformaIdAsync(addLicencaDto.Pessoa, addLicencaDto.Plataforma);
        if (plataformaCadastradaParaPessoa != null) throw new Exception("Esté cliente já possui uma licença para esta plataforma!");

        LicencaCliente licencaModel = new LicencaCliente
        {
            Pessoa          = addLicencaDto.Pessoa,            
            Plataforma      = addLicencaDto.Plataforma,
            ContaCorretora  = int.Parse(addLicencaDto.ContaCorretora),
            CorretoraId     = addLicencaDto.Corretora,
            DataAbertura    = DateTime.Now,
            DataVencimento  = dataVencimento,
            StatusLicencaId = StatusLicenca.PENDENTE
        };

        
        using (var dbContextTransaction = context.Database.BeginTransaction())
        {
            try
            {
                this.geralPersist.Add(licencaModel);
                await this.geralPersist.SaveChangesAsync();                

                HistoricoLicenca historicoLicencaModel = new HistoricoLicenca
                {
                    Tipo = TipoHistoricoLicencaDto.COMPRA,
                    Valor = valor,
                    LicencaClienteId = licencaModel.Id
                };


                this.geralPersist.Add(historicoLicencaModel);
                await this.geralPersist.SaveChangesAsync();
                
                dbContextTransaction.Commit();
                retorno = true;
            } 
            catch (Exception ex)
            {
                dbContextTransaction.Rollback();
                throw new Exception(ex?.InnerException?.Message);
            }

            dbContextTransaction.Dispose();
        }
        return retorno;
    }

    public async Task<LicencaDto?> GetByPessoaIdByPlataformaIdAsync(int pessoaId, int plataformaId)
    {
        var licencaModel = await this.licencaPersist.GetByPessoaIdByPlataformaIdAsync(pessoaId, plataformaId);
        LicencaDto licencaDto;


        if (licencaModel != null)
        {
            licencaDto = this.mapper.Map<LicencaDto>(licencaModel);
            return licencaDto;
        }

        return null;
    }

    public async Task<IList<LicencaDto>> GetByPessoaIdAsync(int pessoaId)
    {
        var licencasModel = await this.licencaPersist.GetByPessoaIdAsync(pessoaId); 

        if (licencasModel != null)
        {
            var licencasDto = this.mapper.Map<IList<LicencaDto>>(licencasModel);
            return licencasDto;
        }

        return new List<LicencaDto>();
    }

    public string getStringEncryptLicenca(string id, string broker)
    {
        //string[] teste = { "64321190", "Xp Investimentos","","","","","" };
        //7E846B635877D53A2BD51B320D9453407E8F4C22C104E1E9481783A50FADD162            

        string[] licencaStr = { id, broker, "", "", "", "", "" };
        string retonro = "";

        // WinDoLibController.SetPositionString(ref licencaStr);
        this.licencaPersist.getLicencaArryString(ref licencaStr);

        if (licencaStr != null)
        {

            retonro = licencaStr[2];
            retonro = retonro + "," + licencaStr[3];
            retonro = retonro + "," + licencaStr[4];
            retonro = retonro + "," + licencaStr[5];
            retonro = retonro + "," + licencaStr[6];


        }
        var s = retonro;

        var s1 = s.Aggregate("", (h, c) => h + ((int)c).ToString("x4"));          // left padded with 0       "0030d835dfcfd835dfdad835dfe5d835dff0d835dffb"
        var s2 = s.Aggregate("", (h, c) => h + string.Format("{0,4:x}", (int)c)); // left padded with space   "  30d835dfcfd835dfdad835dfe5d835dff0d835dffb"

        var sL = BitConverter.ToString(Encoding.Unicode.GetBytes(s)).Replace("-", "");       // Little Endian "300035D8CFDF35D8DADF35D8E5DF35D8F0DF35D8FBDF"
        var sB = BitConverter.ToString(Encoding.BigEndianUnicode.GetBytes(s)).Replace("-", ""); // Big Endian "0030D835DFCFD835DFDAD835DFE5D835DFF0D835DFFB"

        // no encodding "300035D8CFDF35D8DADF35D8E5DF35D8F0DF35D8FBDF"
        byte[] b = new byte[s.Length * sizeof(char)];
        Buffer.BlockCopy(s.ToCharArray(), 0, b, 0, b.Length);
        var sb = BitConverter.ToString(b).Replace("-", "");

        
        return sb;
        
    }


}
