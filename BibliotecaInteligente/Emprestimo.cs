using BibliotecaInteligente.Pessoas;
using BibliotecaInteligente.Produtos;
using System;

namespace BibliotecaInteligente
{
    public class Emprestimo
    {
        public Produto Produto { get; set; }

        public Cliente Cliente { get; set; }

        public Funcionario Responsavel { get; set; }

        public DateTime DataEmprestimo { get; set; }

        public DateTime DataDevolucao { get; set; }

        public Emprestimo(Produto produto, Cliente cliente, Funcionario responsavel, DateTime dataEmprestimo)
        {
            Produto = produto;
            Cliente = cliente;
            Responsavel = responsavel;
            DataEmprestimo = dataEmprestimo;
            DataDevolucao = dataEmprestimo.AddDays(15);
        }

        public override string ToString()
        {
            return $"Produto: {Produto.Nome} - Cliente: {Cliente.Nome} - Data de Devolução: {DataDevolucao}";
        }
    }
}
