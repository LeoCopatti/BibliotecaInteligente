using System;

namespace BibliotecaInteligente.Produtos
{
    public class Livro : Produto
    {
        public string Autor { get; set; }

        public int AnoPublicacao { get; set; }

        public Livro(string nome, DateTime dataEntrada, string autor, int anoPublicacao) : base(nome, dataEntrada)
        {
            Autor = autor;
            AnoPublicacao = anoPublicacao;
        }
    }
}
