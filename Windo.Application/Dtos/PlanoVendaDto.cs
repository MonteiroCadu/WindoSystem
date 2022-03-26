using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windo.Application.Dtos
{
    public class PlanoVendaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string? Descricao { get; set; }
        public int Plataforma { get; set; }
        public int ValidadeLicenca { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; } = true!;

        public virtual PlataformaDto PlataformaNavigation { get; set; } = null!;
        public virtual TempoVencimentoLicencaDto ValidadeLicencaNavigation { get; set; } = null!;
    }
}
