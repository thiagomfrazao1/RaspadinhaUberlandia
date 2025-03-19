using System.ComponentModel.DataAnnotations;

namespace RaspadinhaAPI.Models
{
    public class Empresa
    {
        [Key]
        public string CNPJ { get; set; } // Chave primária
        [Required]
        public string RazaoSocial { get; set; }
        [Required]
        public string NomeResponsavel { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string SenhaHash { get; set; }
    }
}
