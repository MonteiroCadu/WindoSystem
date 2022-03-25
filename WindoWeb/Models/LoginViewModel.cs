using System.ComponentModel.DataAnnotations;

namespace WindoWeb.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Obrigatório"),
            EmailAddress(ErrorMessage ="Informe um email válida")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage ="Obrigatório"),
            DataType(DataType.Password),
            Display(Name ="Senha")]
        public string Password { get; set; } = null!;
        public string? ReturnUrl { get; set; } = "/";
    }
}
