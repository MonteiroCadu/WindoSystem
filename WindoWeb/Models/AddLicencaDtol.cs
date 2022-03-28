using Windo.Application.Dtos;

namespace WindoWeb.Models
{
    public class AddLicencaDtol
    {
        
        public int Pessoa { get; set; }
        public int Plataforma { get; set; }
        public int PlanoVenda { get; set; }
        public string ContaCorretora { get; set; } = "";
    }
}
