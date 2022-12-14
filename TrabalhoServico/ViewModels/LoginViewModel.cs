using System.ComponentModel.DataAnnotations;

namespace TrabalhoServico.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Usuário obrigatório!")]
        [Display(Name = "Usuário")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Senha obrigatória!")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }
        public string ReturnURL { get; set; }
    }
}
