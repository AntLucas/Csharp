namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbFuncao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.cbxtipo = new System.Windows.Forms.ComboBox();
            this.cbxdiferenciacao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Diferenciação = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.Senha = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.btnlog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do micróbio:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(117, 31);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(160, 20);
            this.txbNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de células:";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(117, 86);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(160, 20);
            this.txbNumero.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Função:";
            // 
            // txbFuncao
            // 
            this.txbFuncao.Location = new System.Drawing.Point(117, 116);
            this.txbFuncao.Name = "txbFuncao";
            this.txbFuncao.Size = new System.Drawing.Size(160, 20);
            this.txbFuncao.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descrição:";
            // 
            // txbDesc
            // 
            this.txbDesc.Location = new System.Drawing.Point(117, 149);
            this.txbDesc.Name = "txbDesc";
            this.txbDesc.Size = new System.Drawing.Size(160, 20);
            this.txbDesc.TabIndex = 7;
            // 
            // cbxtipo
            // 
            this.cbxtipo.FormattingEnabled = true;
            this.cbxtipo.Location = new System.Drawing.Point(117, 187);
            this.cbxtipo.Name = "cbxtipo";
            this.cbxtipo.Size = new System.Drawing.Size(121, 21);
            this.cbxtipo.TabIndex = 8;
            this.cbxtipo.SelectedIndexChanged += new System.EventHandler(this.cbxtipo_SelectedIndexChanged);
            // 
            // cbxdiferenciacao
            // 
            this.cbxdiferenciacao.FormattingEnabled = true;
            this.cbxdiferenciacao.Location = new System.Drawing.Point(117, 224);
            this.cbxdiferenciacao.Name = "cbxdiferenciacao";
            this.cbxdiferenciacao.Size = new System.Drawing.Size(121, 21);
            this.cbxdiferenciacao.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Diferenciação
            // 
            this.Diferenciação.AutoSize = true;
            this.Diferenciação.Location = new System.Drawing.Point(16, 224);
            this.Diferenciação.Name = "Diferenciação";
            this.Diferenciação.Size = new System.Drawing.Size(73, 13);
            this.Diferenciação.TabIndex = 11;
            this.Diferenciação.Text = "Diferenciação";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(14, 269);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(16, 62);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(38, 13);
            this.Senha.TabIndex = 13;
            this.Senha.Text = "Senha";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(117, 59);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(100, 20);
            this.txbSenha.TabIndex = 14;
            // 
            // btnlog
            // 
            this.btnlog.Location = new System.Drawing.Point(143, 268);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(57, 24);
            this.btnlog.TabIndex = 15;
            this.btnlog.Text = "Logar";
            this.btnlog.UseVisualStyleBackColor = true;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 304);
            this.Controls.Add(this.btnlog);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.Diferenciação);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxdiferenciacao);
            this.Controls.Add(this.cbxtipo);
            this.Controls.Add(this.txbDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbFuncao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Cadastro de Micróbio";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbFuncao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbDesc;
        private System.Windows.Forms.ComboBox cbxtipo;
        private System.Windows.Forms.ComboBox cbxdiferenciacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Diferenciação;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Button btnlog;
    }
}