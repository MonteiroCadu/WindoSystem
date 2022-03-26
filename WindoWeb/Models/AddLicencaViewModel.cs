using Windo.Application.Dtos;

namespace WindoWeb.Models
{
    public class AddLicencaViewModel
    {
        public int? Id { get; set; }
        public int Pessoa { get; set; }
        public int Plataforma { get; set; }
        public int ContaCorretora { get; set; }

        public int? plataforma { get; set; }
        public int? planoVenda { get; set; }

        public IList<PlataformaDto> Plataformas { get; set; } = null!;
        public IList<PlanoVendaDto> PlanosVendas { get; set; } = null!;
    }
}
