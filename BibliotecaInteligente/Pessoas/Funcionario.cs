using System;

namespace BibliotecaInteligente.Pessoas
{
    public class Funcionario : Pessoa
    {
        public DateTime DataContratacao { get; set; }

        public double Salario { get; set; }

        public Funcionario(string nome, DateTime dataNascimento, string cpf, DateTime dataContratacao, double salario) : base(nome, dataNascimento, cpf)
        {
            DataContratacao = dataContratacao;
            Salario = salario;
        }
    }
}
