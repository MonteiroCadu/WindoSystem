using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windo.Application.Dtos
{
    public class TipoHistoricoLicencaDto
    {
        public TipoHistoricoLicencaDto()
        {
            HistoricoLicencas = new HashSet<HistoricoLicencaDto>();
        }
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string? Descricao { get; set; }

        public virtual ICollection<HistoricoLicencaDto> HistoricoLicencas { get; set; }
    }
}
