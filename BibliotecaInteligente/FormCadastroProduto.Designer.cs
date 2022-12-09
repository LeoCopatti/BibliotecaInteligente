namespace BibliotecaInteligente
{
    partial class FormCadastroProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grpRevista = new System.Windows.Forms.GroupBox();
            this.Editora = new System.Windows.Forms.Label();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.grpLivro = new System.Windows.Forms.GroupBox();
            this.txtAnoPublicacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.rdrLivro = new System.Windows.Forms.RadioButton();
            this.rdrRevista = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.grpRevista.SuspendLayout();
            this.grpLivro.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdrRevista);
            this.groupBox3.Controls.Add(this.rdrLivro);
            this.groupBox3.Controls.Add(this.grpRevista);
            this.groupBox3.Controls.Add(this.grpLivro);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dtpDataEntrada);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtNomeProduto);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 272);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados Base";
            // 
            // grpRevista
            // 
            this.grpRevista.Controls.Add(this.Editora);
            this.grpRevista.Controls.Add(this.txtEditora);
            this.grpRevista.Location = new System.Drawing.Point(11, 144);
            this.grpRevista.Name = "grpRevista";
            this.grpRevista.Size = new System.Drawing.Size(355, 115);
            this.grpRevista.TabIndex = 10;
            this.grpRevista.TabStop = false;
            this.grpRevista.Text = "Revista";
            this.grpRevista.Visible = false;
            // 
            // Editora
            // 
            this.Editora.AutoSize = true;
            this.Editora.Location = new System.Drawing.Point(8, 18);
            this.Editora.Name = "Editora";
            this.Editora.Size = new System.Drawing.Size(40, 13);
            this.Editora.TabIndex = 1;
            this.Editora.Text = "Editora";
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(11, 34);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(338, 20);
            this.txtEditora.TabIndex = 0;
            // 
            // grpLivro
            // 
            this.grpLivro.Controls.Add(this.txtAnoPublicacao);
            this.grpLivro.Controls.Add(this.label4);
            this.grpLivro.Controls.Add(this.label6);
            this.grpLivro.Controls.Add(this.txtAutor);
            this.grpLivro.Location = new System.Drawing.Point(12, 144);
            this.grpLivro.Name = "grpLivro";
            this.grpLivro.Size = new System.Drawing.Size(355, 115);
            this.grpLivro.TabIndex = 6;
            this.grpLivro.TabStop = false;
            this.grpLivro.Text = "Livro";
            // 
            // txtAnoPublicacao
            // 
            this.txtAnoPublicacao.Location = new System.Drawing.Point(11, 80);
            this.txtAnoPublicacao.Name = "txtAnoPublicacao";
            this.txtAnoPublicacao.Size = new System.Drawing.Size(103, 20);
            this.txtAnoPublicacao.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ano Publicação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(11, 34);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(338, 20);
            this.txtAutor.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data de Entrada";
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Location = new System.Drawing.Point(11, 83);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(200, 20);
            this.dtpDataEntrada.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(11, 34);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(355, 20);
            this.txtNomeProduto.TabIndex = 0;
            // 
            // rdrLivro
            // 
            this.rdrLivro.AutoSize = true;
            this.rdrLivro.Checked = true;
            this.rdrLivro.Location = new System.Drawing.Point(16, 121);
            this.rdrLivro.Name = "rdrLivro";
            this.rdrLivro.Size = new System.Drawing.Size(48, 17);
            this.rdrLivro.TabIndex = 11;
            this.rdrLivro.TabStop = true;
            this.rdrLivro.Text = "Livro";
            this.rdrLivro.UseVisualStyleBackColor = true;
            this.rdrLivro.CheckedChanged += new System.EventHandler(this.rdrLivro_CheckedChanged);
            // 
            // rdrRevista
            // 
            this.rdrRevista.AutoSize = true;
            this.rdrRevista.Location = new System.Drawing.Point(101, 121);
            this.rdrRevista.Name = "rdrRevista";
            this.rdrRevista.Size = new System.Drawing.Size(61, 17);
            this.rdrRevista.TabIndex = 12;
            this.rdrRevista.Text = "Revista";
            this.rdrRevista.UseVisualStyleBackColor = true;
            this.rdrRevista.CheckedChanged += new System.EventHandler(this.rdrRevista_CheckedChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(113, 310);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(161, 50);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 375);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormCadastroProduto";
            this.Text = "FormCadastroProduto";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpRevista.ResumeLayout(false);
            this.grpRevista.PerformLayout();
            this.grpLivro.ResumeLayout(false);
            this.grpLivro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grpLivro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtAnoPublicacao;
        private System.Windows.Forms.GroupBox grpRevista;
        private System.Windows.Forms.Label Editora;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.RadioButton rdrRevista;
        private System.Windows.Forms.RadioButton rdrLivro;
        private System.Windows.Forms.Button btnSalvar;
    }
}