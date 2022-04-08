using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windo.Persistence.Dominio
{
    public class StatusLicenca
    {
        public StatusLicenca()
        {
            Licencas = new HashSet<LicencaCliente>();
        }
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Descricao { get; set; } = null!;

        public virtual ICollection<LicencaCliente> Licencas { get; set; }

        public static readonly int ATIVA = 1;
        public static readonly int PENDENTE = 2;
        public static readonly int INATIVA = 3;

    }
}
