using System;
using Windo.Application.Dtos;

namespace Windo.Application.Contratos;
public interface ILicencaService
{
	string getStringEncryptLicenca(string id, string broker);
	Task<bool> AddLicencaToCliente(AddLicencaDto addLicencaDto);
	Task<LicencaDto?> GetByPessoaIdByPlataformaIdAsync(int id, int plataformaId);
	Task<IList<LicencaDto>> GetByPessoaIdAsync(int pessoaId);

}
