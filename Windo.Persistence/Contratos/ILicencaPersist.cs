using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windo.Persistence.Dominio;

namespace Windo.Persistence.Contratos;

public interface ILicencaPersist
{
    void getLicencaArryString(ref string[] parametrs);
    Task<LicencaCliente?> GetByContaCorretoraAndPlataformaAsync(int contaCorretora, int plataforma);
    void Add<T>(T entity) where T : class;
    void Update<T>(T entity) where T : class;
    void Delete<T>(T entity) where T : class;
    void DeleteRange<T>(T[] entity) where T : class;
    Task<bool> SaveChangesAsync();
    Task<IList<LicencaCliente>> GetAllActiveAsync(int top);
    Task<LicencaCliente?> GetByIdAsync(int id);
    Task<LicencaCliente?> GetByPessoaIdByPlataformaIdAsync(int id, int plataformaId);
    Task<IList<LicencaCliente>> GetByPessoaIdAsync(int pessoaId);
}


