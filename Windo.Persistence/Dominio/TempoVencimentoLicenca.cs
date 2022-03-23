using System;
using System.Collections.Generic;

namespace Windo.Persistence.Dominio
{
    public partial class TempoVencimentoLicenca
    {
        public TempoVencimentoLicenca()
        {
            PlanoVenda = new HashSet<PlanoVenda>();
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string? Descricao { get; set; }
        public int NumeroDias { get; set; }

        public virtual ICollection<PlanoVenda> PlanoVenda { get; set; }
    }
}
