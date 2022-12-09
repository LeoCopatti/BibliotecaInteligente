using BibliotecaInteligente.Produtos;
using System;
using System.Windows.Forms;

namespace BibliotecaInteligente
{
    public partial class FormCadastroProduto : Form
    {
        public Form1 FormPrincipal { get; set; }

        public FormCadastroProduto(Form1 formPrincipal)
        {
            InitializeComponent();
            FormPrincipal = formPrincipal;
        }

        private void rdrRevista_CheckedChanged(object sender, EventArgs e)
        {
            if (rdrRevista.Checked)
            {
                grpLivro.Visible = false;
                grpRevista.Visible = true;
                rdrLivro.Checked = false;
            }
            else
            {
                grpLivro.Visible = true;
                grpRevista.Visible = false;
                rdrLivro.Checked = true;
            }
        }

        private void rdrLivro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdrLivro.Checked)
            {
                grpLivro.Visible = true;
                grpRevista.Visible = false;
                rdrRevista.Checked = false;
            }
            else
            {
                grpLivro.Visible = false;
                grpRevista.Visible = true;
                rdrRevista.Checked = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto;
            if (rdrLivro.Checked)
                produto = new Livro(txtNomeProduto.Text, DateTime.Parse(dtpDataEntrada.Text), txtAutor.Text, Convert.ToInt32(txtAnoPublicacao.Text));
            else
                produto = new Revista(txtNomeProduto.Text, DateTime.Parse(dtpDataEntrada.Text), txtEditora.Text);

            FormPrincipal.Produtos.Add(produto);

            ProcessaAdicao();
        }

        private void ProcessaAdicao()
        {
            FormPrincipal.AtualizaCombos();
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            txtNomeProduto.Text = "";
            txtAutor.Text = "";
            txtAnoPublicacao.Text = "";
            txtEditora.Text = "";
            dtpDataEntrada.Text = DateTime.Now.ToString();
        }
    }
}
