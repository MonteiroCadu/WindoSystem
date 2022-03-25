using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windo.Application.Dtos
{
    public class RoboDto
    {
        public RoboDto()
        {
            Plataformas = new HashSet<PlataformaDto>();
        }

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricacao { get; set; }
        public int QtdLote { get; set; }

        public virtual ICollection<PlataformaDto> Plataformas { get; set; }
    }
}
