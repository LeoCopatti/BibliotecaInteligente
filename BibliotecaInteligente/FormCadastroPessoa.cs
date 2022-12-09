using BibliotecaInteligente.Pessoas;
using System;
using System.Windows.Forms;

namespace BibliotecaInteligente
{
    public partial class FormCadastroPessoa : Form
    {
        public Form1 FormPrincipal { get; set; }

        public FormCadastroPessoa(Form1 formPrincipal)
        {
            InitializeComponent();

            FormPrincipal = formPrincipal;
        }

        private void btnCriarCliente_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente(txtNome.Text, DateTime.Parse(dtpDataNascimento.Text), txtCpf.Text);

            FormPrincipal.Clientes.Add(cliente);

            ProcessaAdicao();
        }

        private void btnCriarFuncionario_Click(object sender, EventArgs e)
        {
            var funcionario = new Funcionario( txtNome.Text, 
                                               DateTime.Parse(dtpDataNascimento.Text), 
                                               txtCpf.Text, 
                                               DateTime.Parse(dtpDataContratacao.Text), 
                                               Convert.ToDouble(txtSalario.Text));

            FormPrincipal.Funcionarios.Add(funcionario);

            ProcessaAdicao();
        }

        private void ProcessaAdicao()
        {
            FormPrincipal.AtualizaCombos();
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtSalario.Text = "";
            dtpDataNascimento.Text = DateTime.Now.ToString();
            dtpDataContratacao.Text = DateTime.Now.ToString();
        }
    }
}
