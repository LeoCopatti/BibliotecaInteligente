using System;

namespace BibliotecaInteligente.Produtos
{
    public class Revista : Produto
    {
        public string Editora { get; set; }

        public Revista(string nome, DateTime dataEntrada, string editora) : base(nome, dataEntrada)
        {
            Editora = editora;
        }
    }
}
