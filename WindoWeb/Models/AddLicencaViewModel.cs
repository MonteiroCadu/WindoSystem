using Windo.Application.Dtos;

namespace WindoWeb.Models
{
    public class AddLicencaViewModel
    {
        public int? Id { get; set; }
        public int Pessoa { get; set; }
        public int Plataforma { get; set; }
        public int ContaCorretora { get; set; }

        public List<PlataformaDto> Plataformas { get; set; } = null!;
    }
}
