
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Windo.Persistence.Dominio
{
    
    public class Corretora
    {
        public Corretora()
        {
            LicencaClientes = new HashSet<LicencaCliente>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Nome { get; set; } = null!;

        public virtual ICollection<LicencaCliente> LicencaClientes { get; set; }
    }
}
