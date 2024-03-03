namespace AplicacaoWeb.Models
{
    public class Pessoa
    {
        string? nome;
        string? idade;
        string? cpf;

        public string Nome { get => nome ?? ""; set => nome = value; }
        public string Idade { get => idade ?? ""; set => idade = value; }
        public string Cpf { get => cpf ?? ""; set => cpf = value; }
    }
}
