using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windo.Application.Dtos
{
    public class PlataformaDto
    {
       
        public int Id { get; set; }        
        public string Nome { get; set; } = null!;        
        public string? Descricao { get; set; }        
        //public virtual ICollection<LicencaCliente> LicencaClientes { get; set; }        
        //public virtual ICollection<PlanoVenda> PlanoVenda { get; set; }
        //public virtual ICollection<Robo> Robos { get; set; }
    }
}
