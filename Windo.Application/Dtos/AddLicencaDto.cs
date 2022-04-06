using Windo.Application.Dtos;

namespace Windo.Application.Dtos
{
    public class AddLicencaDto
    {
        public int id { get; set; } = 0;
        public int Pessoa { get; set; }
        public int Plataforma { get; set; }
        public int PlanoVenda { get; set; }
        public int Corretora { get; set; }
        public string ContaCorretora { get; set; } = "";
    }
}
