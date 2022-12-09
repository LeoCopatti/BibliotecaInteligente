namespace BibliotecaInteligente
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadPessoa = new System.Windows.Forms.Button();
            this.btnCadProdutos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grp = new System.Windows.Forms.GroupBox();
            this.btnEmprestimo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbResponsavel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lstEmprestimos = new System.Windows.Forms.ListBox();
            this.lblEmprestimos = new System.Windows.Forms.Label();
            this.grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadPessoa
            // 
            this.btnCadPessoa.Location = new System.Drawing.Point(203, 73);
            this.btnCadPessoa.Name = "btnCadPessoa";
            this.btnCadPessoa.Size = new System.Drawing.Size(155, 39);
            this.btnCadPessoa.TabIndex = 0;
            this.btnCadPessoa.Text = "Cadastro de Pessoas";
            this.btnCadPessoa.UseVisualStyleBackColor = true;
            this.btnCadPessoa.Click += new System.EventHandler(this.btnCadPessoa_Click);
            // 
            // btnCadProdutos
            // 
            this.btnCadProdutos.Location = new System.Drawing.Point(426, 73);
            this.btnCadProdutos.Name = "btnCadProdutos";
            this.btnCadProdutos.Size = new System.Drawing.Size(155, 39);
            this.btnCadProdutos.TabIndex = 1;
            this.btnCadProdutos.Text = "Cadastro de Produtos";
            this.btnCadProdutos.UseVisualStyleBackColor = true;
            this.btnCadProdutos.Click += new System.EventHandler(this.btnCadProdutos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Biblioteca";
            // 
            // grp
            // 
            this.grp.Controls.Add(this.btnEmprestimo);
            this.grp.Controls.Add(this.label4);
            this.grp.Controls.Add(this.cmbProduto);
            this.grp.Controls.Add(this.label3);
            this.grp.Controls.Add(this.cmbResponsavel);
            this.grp.Controls.Add(this.label2);
            this.grp.Controls.Add(this.cmbCliente);
            this.grp.Location = new System.Drawing.Point(46, 151);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(297, 269);
            this.grp.TabIndex = 4;
            this.grp.TabStop = false;
            this.grp.Text = "Retirada de Produtos";
            // 
            // btnEmprestimo
            // 
            this.btnEmprestimo.Location = new System.Drawing.Point(6, 196);
            this.btnEmprestimo.Name = "btnEmprestimo";
            this.btnEmprestimo.Size = new System.Drawing.Size(155, 39);
            this.btnEmprestimo.TabIndex = 7;
            this.btnEmprestimo.Text = "Realizar Empréstimo";
            this.btnEmprestimo.UseVisualStyleBackColor = true;
            this.btnEmprestimo.Click += new System.EventHandler(this.btnEmprestimo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Produto";
            // 
            // cmbProduto
            // 
            this.cmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(6, 139);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(285, 21);
            this.cmbProduto.TabIndex = 10;
            cmbProduto.ValueMember = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Responsável";
            // 
            // cmbResponsavel
            // 
            this.cmbResponsavel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResponsavel.FormattingEnabled = true;
            this.cmbResponsavel.Location = new System.Drawing.Point(6, 87);
            this.cmbResponsavel.Name = "cmbResponsavel";
            this.cmbResponsavel.Size = new System.Drawing.Size(285, 21);
            this.cmbResponsavel.TabIndex = 8;
            this.cmbResponsavel.ValueMember = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(6, 36);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(285, 21);
            this.cmbCliente.TabIndex = 0;
            this.cmbCliente.ValueMember = null;
            // 
            // lstEmprestimos
            // 
            this.lstEmprestimos.FormattingEnabled = true;
            this.lstEmprestimos.Location = new System.Drawing.Point(352, 156);
            this.lstEmprestimos.Name = "lstEmprestimos";
            this.lstEmprestimos.Size = new System.Drawing.Size(436, 264);
            this.lstEmprestimos.TabIndex = 5;
            // 
            // lblEmprestimos
            // 
            this.lblEmprestimos.AutoSize = true;
            this.lblEmprestimos.Location = new System.Drawing.Point(349, 140);
            this.lblEmprestimos.Name = "lblEmprestimos";
            this.lblEmprestimos.Size = new System.Drawing.Size(66, 13);
            this.lblEmprestimos.TabIndex = 6;
            this.lblEmprestimos.Text = "Empréstimos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEmprestimos);
            this.Controls.Add(this.lstEmprestimos);
            this.Controls.Add(this.grp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadProdutos);
            this.Controls.Add(this.btnCadPessoa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadPessoa;
        private System.Windows.Forms.Button btnCadProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.Button btnEmprestimo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbResponsavel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ListBox lstEmprestimos;
        private System.Windows.Forms.Label lblEmprestimos;
    }
}

