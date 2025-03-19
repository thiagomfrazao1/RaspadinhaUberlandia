namespace RaspadinhaUberlandia.ITarefas
{
    public interface IRegistroUsuario
    {
        string CPF { get; set; }
        string Email { get; set; }
        string NomeCompletol { get; set; }
        string Senha { get; set; }
        string Telefone { get; set; }
    }
}