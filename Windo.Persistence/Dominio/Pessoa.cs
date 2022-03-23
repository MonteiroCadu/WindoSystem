using System;
using System.Collections.Generic;

namespace Windo.Persistence.Dominio
{
    public partial class Pessoa
    {
        public Pessoa()
        {
            LicencaClientes = new HashSet<LicencaCliente>();
        }

        public int Id { get; set; }
        public string NomeCompleto { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Telefone { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string? Documento { get; set; }

        public virtual ICollection<LicencaCliente> LicencaClientes { get; set; }
    }
}
