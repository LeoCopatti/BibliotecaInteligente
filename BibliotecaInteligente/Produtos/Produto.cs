using System;

namespace BibliotecaInteligente.Produtos
{
    public abstract class Produto
    {
        public Produto(string nome, DateTime dataEntrada)
        {
            Nome = nome;
            DataEntrada = dataEntrada;
        }
        public string Nome { get; set; }

        public DateTime DataEntrada { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
