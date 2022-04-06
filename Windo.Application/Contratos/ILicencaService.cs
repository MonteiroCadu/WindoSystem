using System;
using Windo.Application.Dtos;

namespace Windo.Application.Contratos;
public interface ILicencaService
{
	string getStringEncryptLicenca(string id, string broker);
	Task AddLicencaToCliente(AddLicencaDto addLicencaDto);
}
