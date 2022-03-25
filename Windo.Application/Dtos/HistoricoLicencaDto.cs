using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windo.Application.Dtos
{
    public class HistoricoLicencaDto
    {
       
        public int Id { get; set; }
        public int? Tipo { get; set; }
        public decimal Valor { get; set; }

        public virtual TipoHistoricoLicencaDto? TipoNavigation { get; set; }
    }
}
