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

        public static readonly int COMPRA = 1;
        public static readonly int ATIVACAO = 2;
        public static readonly int RENOVACAO = 3;
        public static readonly int ATIVACAO_RENOVACAO = 4;
        public static readonly int REATIVACAO = 5;
        public static readonly int ATIVACAO_REATIVACAO = 6;

        public virtual ICollection<HistoricoLicencaDto> HistoricoLicencas { get; set; }
    }
}
