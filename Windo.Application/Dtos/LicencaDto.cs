using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windo.Application.Dtos
{
    public class LicencaDto
    {
       
        public int Id { get; set; }        
        public int Pessoa { get; set; }        
        public int Plataforma { get; set; }        
        public int ContaCorretora { get; set; }        
        public DateTime DataAbertura { get; set; }       
        public DateTime DataVencimento { get; set; }
        public int StatusLicencaId { get; set; }
        public int? Corretora { get; set; } = null!;
        public virtual PessoaDto PessoaNavigation { get; set; } = null!;        
        public virtual PlataformaDto PlataformaNavigation { get; set; } = null!;
        public virtual CorretoraDto CorretoraNavigation { get; set; } = null!;
        public virtual StatusLicencaDto StatusLicencaNavigation { get; set; } = null!;
    }
}
