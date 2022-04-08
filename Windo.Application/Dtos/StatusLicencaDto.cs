using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windo.Application.Dtos
{
    public class StatusLicencaDto
    {
        public StatusLicencaDto()
        {
            Licencas = new HashSet<LicencaDto>();
        }
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Descricao { get; set; } = null!;

        public virtual ICollection<LicencaDto> Licencas { get; set; }
    }
}
