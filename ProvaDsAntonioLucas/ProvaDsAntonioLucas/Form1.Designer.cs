namespace ProvaDsAntonioLucas
{
    partial class Form1
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
            this.lblSalvar = new System.Windows.Forms.Button();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txbPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalvar
            // 
            this.lblSalvar.Location = new System.Drawing.Point(116, 209);
            this.lblSalvar.Name = "lblSalvar";
            this.lblSalvar.Size = new System.Drawing.Size(176, 29);
            this.lblSalvar.TabIndex = 21;
            this.lblSalvar.Text = "Cadastrar";
            this.lblSalvar.UseVisualStyleBackColor = true;
            this.lblSalvar.Click += new System.EventHandler(this.lblSalvar_Click_1);
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(116, 113);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(176, 20);
            this.txbTelefone.TabIndex = 20;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(46, 113);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(49, 13);
            this.lblTel.TabIndex = 19;
            this.lblTel.Text = "Telefone";
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(116, 78);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(176, 20);
            this.txbEndereco.TabIndex = 18;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(46, 78);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(53, 13);
            this.lblEnd.TabIndex = 17;
            this.lblEnd.Text = "Endereço";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(116, 42);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(176, 20);
            this.txbNome.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nome";
            // 
            // cbCidade
            // 
            this.cbCidade.Location = new System.Drawing.Point(116, 169);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(176, 21);
            this.cbCidade.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cidade";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "SP",
            "BA",
            "SC",
            "AC"});
            this.cbEstado.Location = new System.Drawing.Point(116, 140);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(176, 21);
            this.cbEstado.TabIndex = 14;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Estado";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(325, 44);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(623, 198);
            this.dgvClientes.TabIndex = 22;
            // 
            // txbPesquisar
            // 
            this.txbPesquisar.Location = new System.Drawing.Point(325, 18);
            this.txbPesquisar.Name = "txbPesquisar";
            this.txbPesquisar.Size = new System.Drawing.Size(193, 20);
            this.txbPesquisar.TabIndex = 23;
            this.txbPesquisar.TextChanged += new System.EventHandler(this.txbPesquisar_TextChanged);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(538, 15);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 24;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 277);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.txbPesquisar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.lblSalvar);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cadastro de cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lblSalvar;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txbPesquisar;
        private System.Windows.Forms.Button btnPesquisa;
    }
}

