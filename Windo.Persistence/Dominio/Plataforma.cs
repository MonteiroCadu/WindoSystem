using System;
using System.Collections.Generic;

namespace Windo.Persistence.Dominio
{
    public partial class Plataforma
    {
        public Plataforma()
        {
            LicencaClientes = new HashSet<LicencaCliente>();
            PlanoVenda = new HashSet<PlanoVenda>();
            Robos = new HashSet<Robo>();
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string? Descricao { get; set; }

        public bool Ativa { get; set; } = true!;

        public virtual ICollection<LicencaCliente> LicencaClientes { get; set; }
        public virtual ICollection<PlanoVenda> PlanoVenda { get; set; }

        public virtual ICollection<Robo> Robos { get; set; }
    }
}
