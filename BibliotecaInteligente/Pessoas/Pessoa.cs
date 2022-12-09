using System;

namespace BibliotecaInteligente.Pessoas
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Cpf { get; set; }

        public Pessoa(string nome, DateTime dataNascimento, string cpf)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Cpf = cpf;  
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
