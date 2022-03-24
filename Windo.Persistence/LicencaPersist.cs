using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windo.Persistence.Contratos;
using Windo.Persistence.Dominio;

namespace Windo.Persistence
{
    public  class LicencaPersist : GeralPersist, ILicencaPersist
    {
        private readonly IConectionFactory conectionFactory;

        public LicencaPersist(IConectionFactory conectionFactory, windo_baseContext contexto) : base(contexto)
        {
            this.conectionFactory = conectionFactory;
        }

        public async Task<LicencaCliente?> GetByIdAsync(int id)
        {            

            IQueryable<LicencaCliente> query = _contexto.LicencaClientes
                .Where(l => l.Id == id)
                .AsNoTracking();          

            return await query.FirstOrDefaultAsync();
        }
        public async Task<LicencaCliente?> GetByContaCorretoraAndPlataformaAsync(int contaCorretora, int plataforma)
        {
            IQueryable<LicencaCliente> query = _contexto.LicencaClientes
                .Where(l => l.ContaCorretora == contaCorretora && l.Plataforma == plataforma)
                .AsNoTracking();

            return await query.FirstOrDefaultAsync();
        }

        public async Task<IList<LicencaCliente>> GetAllActiveAsync(int top)
        {
            IQueryable<LicencaCliente> query = _contexto.LicencaClientes
                .Include(l => l.Pessoa)
                .Include(l => l.Plataforma)
                .Where(l => l.Ativa == 1)
                .OrderByDescending(l => l.DataAbertura)
                .Take(top)
                .AsNoTracking();
                

            return await query.ToListAsync();

        }

        public void getLicencaArryString(ref string[] parametrs)
        {           
            
            try
            {
                string conta_corretora = parametrs[0];
                SqlConnection connection = this.conectionFactory.getConection();
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT ativa, setup_nome, lote, data_vencimento FROM licencas where conta_corretora=" + conta_corretora, connection);


                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    parametrs[2] = (String) reader.GetValue(0);
                    parametrs[3] = (String) reader.GetValue(1);
                    parametrs[4] = (String) reader.GetValue(2);
                    //parametrs[6] = "mxbot1";
                    parametrs[6] = (String) reader.GetValue(3);
                }
                else
                {
                    parametrs[2] = " ";
                    parametrs[3] = " ";
                    parametrs[4] = " ";
                    parametrs[5] = "Licencença não encontrada";
                    parametrs[6] = " ";
                }

                connection.Close();


            }
            catch (Exception )
            {
                parametrs[2] = " ";
                parametrs[3] = " ";
                parametrs[4] = " ";
                parametrs[5] = "Erro de Conexão com o servidor de licença";
            }
            
        }

        
    }
}

