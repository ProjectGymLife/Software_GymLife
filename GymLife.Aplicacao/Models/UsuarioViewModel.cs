using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GymLife.Models
{
    public class UsuarioViewModel
    {
        [Required(ErrorMessage = "É Necessário informar um E-mail." )]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "É Necessário infomar uma Senha.")]
        [PasswordPropertyText]
        public string Senha { get; set; }

        public bool LembrarSenha { get; set; } = true;
    }
}
