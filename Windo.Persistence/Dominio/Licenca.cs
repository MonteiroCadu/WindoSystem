using System;
using System.Collections.Generic;

namespace Windo.Persistence.Dominio
{
    public partial class Licenca
    {
        public int ContaCorretora { get; set; }
        public string BrokerName { get; set; } = null!;
        public string? ClienteNome { get; set; }
        public string SetupNome { get; set; } = null!;
        public DateTime DataAbertura { get; set; }
        public DateTime? DataVencimento { get; set; }
        public byte Ativa { get; set; }
        public int Lote { get; set; }
        public int Id { get; set; }
        public int Plataforma { get; set; }

        public virtual Plataforma PlataformaNavigation { get; set; } = null!;
    }
}
