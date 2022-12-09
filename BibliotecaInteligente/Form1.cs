using BibliotecaInteligente.Pessoas;
using BibliotecaInteligente.Produtos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BibliotecaInteligente
{
    public partial class Form1 : Form
    {
        public List<Funcionario> Funcionarios { get; set; }

        public List<Cliente> Clientes { get; set; }

        public List<Produto> Produtos { get; set; }

        public Form1()
        {
            InitializeComponent();
            Funcionarios = new List<Funcionario>();
            Clientes = new List<Cliente>();
            Produtos = new List<Produto>();
        }

        private void btnCadPessoa_Click(object sender, EventArgs e)
        {
            var formCadastro = new FormCadastroPessoa(this);

            formCadastro.Show();
        }

        private void btnCadProdutos_Click(object sender, EventArgs e)
        {
            var formCadastro = new FormCadastroProduto(this);

            formCadastro.Show();
        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            lstEmprestimos.Items.Add(new Emprestimo((Produto)cmbProduto.SelectedItem, (Cliente)cmbCliente.SelectedItem, (Funcionario)cmbResponsavel.SelectedItem, DateTime.Now));
        }

        public void AtualizaCombos()
        {
            LimpaCombos();

            cmbCliente.Items.AddRange(Clientes.ToArray());
            cmbResponsavel.Items.AddRange(Funcionarios.ToArray());
            cmbProduto.Items.AddRange(Produtos.ToArray());
        }

        private void LimpaCombos()
        {
            cmbCliente.Items.Clear();
            cmbResponsavel.Items.Clear();
            cmbProduto.Items.Clear();
        }
    }
}
