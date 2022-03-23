using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windo.Application.Dtos
{
    public class PessoaDto
    {
        
        public int? Id { get; set; }
        [Display(Name ="Nome Completo")]
        [Required(ErrorMessage ="Obrigatório"),
            MaxLength(150, ErrorMessage = "máximo 150 caracteres"),
            MinLength(11, ErrorMessage = "Minimo 10 caracteres")]
        public string NomeCompleto { get; set; } = null!;

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Obrigatório"),EmailAddress(ErrorMessage ="Informe um e-mail válido")]
        public string Email { get; set; } = null!;
        
        [Required(ErrorMessage = "Obrigatório"), Phone(ErrorMessage = "Informe um telefone válido")]
        public string? Telefone { get; set; }
        
        public DateTime? DataNascimento { get; set; }

        [Required(ErrorMessage = "Obrigatório"), 
            MaxLength(14,ErrorMessage ="máximo 14 caracteres"),
            MinLength(11,ErrorMessage ="Minimo 11 caracteres")]
        public string? Documento { get; set; }
        
        public virtual ICollection<LicencaDto>? LicencaClientes { get; set; }
    }
}
