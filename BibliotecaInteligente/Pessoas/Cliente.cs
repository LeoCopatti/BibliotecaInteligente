using System;

namespace BibliotecaInteligente.Pessoas
{
    public class Cliente : Pessoa
    {
        public double MultasPendentes { get; set; }

        public Cliente(string nome, DateTime dataNascimento, string cpf) : base(nome, dataNascimento, cpf)
        {
            MultasPendentes = 0;
        }

        public void AdicionaMulta(double valor)
        {
            MultasPendentes += valor;
        }

        public void PagaMulta(double valor)
        {
            MultasPendentes -= valor;
        }
    }
}
