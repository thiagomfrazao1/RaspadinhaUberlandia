using System.ComponentModel.DataAnnotations;
using RaspadinhaUberlandia.ITarefas;

namespace RaspadinhaDigital.API.Models
{
    public class RegistroUsuario : IRegistroUsuario
    {
        public string CPF { get; set; }
        [Required]
        public string NomeCompletol { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Senha { get; set; }
    }

    public class RegistroEmpresa : IRegistroEmpresa
    {
        public string CNPJ { get; set; }
        [Required]
        public string RazaoSocial { get; set; }
        [Required]
        public string NomeResponsavel { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Senha { get; set; }
    }
}


public class UsuarioAcesso : IUsuarioAcesso
{
    public int Cpf { get; set; }
    public string Senha { get; set; }
}

public class EmpresaAcesso : IEmpresaAcesso
{
    public int Cpf { get; set; }
    public string Senha { get; set; }
}

public class RecuperarSenha : IRecuperarSenha
{
    public int Cpf { get; set; }
    public string Email { get; set; }
}

public class Resultado
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
    }