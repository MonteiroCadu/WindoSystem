using System;
using System.Collections.Generic;

namespace Windo.Persistence.Dominio
{
    public partial class TipoHistoricoLicenca
    {
        public TipoHistoricoLicenca()
        {
            HistoricoLicencas = new HashSet<HistoricoLicenca>();
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string? Descricao { get; set; }

        public virtual ICollection<HistoricoLicenca> HistoricoLicencas { get; set; }
    }
}
