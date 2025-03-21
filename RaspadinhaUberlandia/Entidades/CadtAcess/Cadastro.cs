using System.ComponentModel.DataAnnotations;
using RaspadinhaUberlandia.ITarefas;

namespace RaspadinhaUberlandia.Entidades.CadtAcess
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

public class RecuperarSenhaUsuario : IRecuperarSenhaUsuario
{
    public int Cpf { get; set; }
    public string Email { get; set; }
}

public class RecuperarSenhaEmpresa : IRecuperarSenhaEmpresa
{
    public int CNPJ { get; set; }
    public string Email { get; set; }
}

// Modelo para solicitação de exclusão do usuário
public class ExcluirUsuario : IExcluirUsuario
{
    public string Cpf { get; set; }
    public string Telefone { get; set; }
}

// Modelo para confirmação de exclusão do usuário
public class ConfirmarExclusaoUsuario : IConfirmarExclusaoUsuario
{
    public string Cpf { get; set; }
    public string CodigoConfirmacao { get; set; }
}

// Modelo para solicitação de exclusão da empresa
public class ExcluirEmpresa : IExcluirEmpresa
{
    public string Cnpj { get; set; }
    public string Telefone { get; set; }
}

// Modelo para confirmação de exclusão da empresa
public class ConfirmarExclusaoEmpresa : IConfirmarExclusaoEmpresa
{
    public string Cnpj { get; set; }
    public string CodigoConfirmacao { get; set; }
}
