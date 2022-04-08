using System;
using System.Collections.Generic;

namespace Windo.Persistence.Dominio
{
    public partial class LicencaCliente
    {
        public int Id { get; set; }
        public int Pessoa { get; set; }
        public int Plataforma { get; set; }
        public int ContaCorretora { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataVencimento { get; set; }
        public int StatusLicencaId { get; set; }
        public int CorretoraId { get; set; }
        public virtual Pessoa PessoaNavigation { get; set; } = null!;
        public virtual Plataforma PlataformaNavigation { get; set; } = null!;
        public virtual Corretora CorretoraNavigation { get; set; } = null!;
        public virtual StatusLicenca StatusLicencaNavigation { get; set; } = null!;

    }
}
