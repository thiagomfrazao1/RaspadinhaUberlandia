using System.ComponentModel.DataAnnotations;

namespace RaspadinhaDigital.API.Models
{
    public class Usuario
    {
        [Key]
        public string CPF { get; set; } // Chave primária
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string SenhaHash { get; set; } // Armazena a senha criptografada
    }
}