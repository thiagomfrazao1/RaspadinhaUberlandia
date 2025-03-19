namespace RaspadinhaUberlandia.ITarefas
{
    public interface IRegistroEmpresa
    {
        string CNPJ { get; set; }
        string Email { get; set; }
        string NomeResponsavel { get; set; }
        string RazaoSocial { get; set; }
        string Senha { get; set; }
        string Telefone { get; set; }
    }
}