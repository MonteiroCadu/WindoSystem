using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windo.Application.Dtos
{
    public class PlataformaDto
    {

        public PlataformaDto()
        {
            LicencaClientes = new HashSet<LicencaDto>();
            PlanoVenda = new HashSet<PlanoVendaDto>();
            Robos = new HashSet<RoboDto>();
        }
        public int Id { get; set; }        
        public string Nome { get; set; } = null!;        
        public string? Descricao { get; set; }
        public bool Ativa { get; set; } = true!;
        public virtual ICollection<LicencaDto> LicencaClientes { get; set; }        
        public virtual ICollection<PlanoVendaDto> PlanoVenda { get; set; }
        public virtual ICollection<RoboDto> Robos { get; set; }
    }
}
