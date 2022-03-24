
using System.ComponentModel.DataAnnotations;
using Windo.Application.Helpers;

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
        public string Telefone { get; set; } = null!;

        public DateTime? DataNascimento { get; set; }

        [Required(ErrorMessage = "Obrigatório"),
            MaxLength(14, ErrorMessage = "máximo 14 caracteres"),
            MinLength(11, ErrorMessage = "Minimo 11 caracteres"),
            CustomValidationCPF(ErrorMessage = "CPF inválido")
            ]
        public string Documento { get; set; } = null!;

        public virtual ICollection<LicencaDto>? LicencaClientes { get; set; }
    }
}
