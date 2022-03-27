using System;
using System.Collections.Generic;

namespace Windo.Persistence.Dominio
{
    public partial class PlanoVenda
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string? Descricao { get; set; }
        public int Plataforma { get; set; }
        public int ValidadeLicenca { get; set; }
        public decimal Valor { get; set; }        

        public bool Ativo { get; set; } = true!;

        public virtual Plataforma PlataformaNavigation { get; set; } = null!;
        public virtual TempoVencimentoLicenca ValidadeLicencaNavigation { get; set; } = null!;
    }
}
