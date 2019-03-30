namespace ProvaDsAntonioLucas
{
    partial class Form2
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
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txbPesquisar = new System.Windows.Forms.TextBox();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFuncao = new System.Windows.Forms.ComboBox();
            this.cbEspecialidade = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(603, 68);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 38;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click_1);
            // 
            // txbPesquisar
            // 
            this.txbPesquisar.Location = new System.Drawing.Point(390, 71);
            this.txbPesquisar.Name = "txbPesquisar";
            this.txbPesquisar.Size = new System.Drawing.Size(193, 20);
            this.txbPesquisar.TabIndex = 37;
            this.txbPesquisar.TextChanged += new System.EventHandler(this.txbPesquisar_TextChanged_1);
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(390, 97);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(738, 198);
            this.dgvFuncionarios.TabIndex = 36;
            // 
            // lblSalvar
            // 
            this.lblSalvar.Location = new System.Drawing.Point(181, 296);
            this.lblSalvar.Name = "lblSalvar";
            this.lblSalvar.Size = new System.Drawing.Size(176, 29);
            this.lblSalvar.TabIndex = 35;
            this.lblSalvar.Text = "Cadastrar";
            this.lblSalvar.UseVisualStyleBackColor = true;
            this.lblSalvar.Click += new System.EventHandler(this.lblSalvar_Click);
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(181, 139);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(176, 20);
            this.txbTelefone.TabIndex = 34;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(111, 139);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(49, 13);
            this.lblTel.TabIndex = 33;
            this.lblTel.Text = "Telefone";
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(181, 104);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(176, 20);
            this.txbEndereco.TabIndex = 32;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(111, 104);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(53, 13);
            this.lblEnd.TabIndex = 31;
            this.lblEnd.Text = "Endereço";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(181, 68);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(176, 20);
            this.txbNome.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nome";
            // 
            // cbCidade
            // 
            this.cbCidade.Location = new System.Drawing.Point(181, 195);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(176, 21);
            this.cbCidade.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 26;
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
            this.cbEstado.Location = new System.Drawing.Point(181, 166);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(176, 21);
            this.cbEstado.TabIndex = 28;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Função";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Especialidade";
            // 
            // cbFuncao
            // 
            this.cbFuncao.FormattingEnabled = true;
            this.cbFuncao.Location = new System.Drawing.Point(181, 225);
            this.cbFuncao.Name = "cbFuncao";
            this.cbFuncao.Size = new System.Drawing.Size(176, 21);
            this.cbFuncao.TabIndex = 41;
            this.cbFuncao.SelectedIndexChanged += new System.EventHandler(this.cbFuncao_SelectedIndexChanged);
            // 
            // cbEspecialidade
            // 
            this.cbEspecialidade.FormattingEnabled = true;
            this.cbEspecialidade.Location = new System.Drawing.Point(181, 257);
            this.cbEspecialidade.Name = "cbEspecialidade";
            this.cbEspecialidade.Size = new System.Drawing.Size(176, 21);
            this.cbEspecialidade.TabIndex = 42;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 362);
            this.Controls.Add(this.cbEspecialidade);
            this.Controls.Add(this.cbFuncao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.txbPesquisar);
            this.Controls.Add(this.dgvFuncionarios);
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
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txbPesquisar;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFuncao;
        private System.Windows.Forms.ComboBox cbEspecialidade;

    }
}