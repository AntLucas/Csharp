namespace insert_csharp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnPessoaDoc = new System.Windows.Forms.Button();
            this.btnPessoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCliente);
            this.groupBox1.Controls.Add(this.btnFuncionario);
            this.groupBox1.Controls.Add(this.btnPessoaDoc);
            this.groupBox1.Controls.Add(this.btnPessoa);
            this.groupBox1.Location = new System.Drawing.Point(10, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entidades";
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(136, 59);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(98, 32);
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click_1);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Location = new System.Drawing.Point(32, 59);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(98, 32);
            this.btnFuncionario.TabIndex = 2;
            this.btnFuncionario.Text = "Funcionário";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click_1);
            // 
            // btnPessoaDoc
            // 
            this.btnPessoaDoc.Location = new System.Drawing.Point(136, 21);
            this.btnPessoaDoc.Name = "btnPessoaDoc";
            this.btnPessoaDoc.Size = new System.Drawing.Size(98, 32);
            this.btnPessoaDoc.TabIndex = 1;
            this.btnPessoaDoc.Text = "Documentos";
            this.btnPessoaDoc.UseVisualStyleBackColor = true;
            this.btnPessoaDoc.Click += new System.EventHandler(this.btnPessoaDoc_Click_1);
            // 
            // btnPessoa
            // 
            this.btnPessoa.Location = new System.Drawing.Point(32, 21);
            this.btnPessoa.Name = "btnPessoa";
            this.btnPessoa.Size = new System.Drawing.Size(98, 32);
            this.btnPessoa.TabIndex = 0;
            this.btnPessoa.Text = "Pessoa";
            this.btnPessoa.UseVisualStyleBackColor = true;
            this.btnPessoa.Click += new System.EventHandler(this.btnPessoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 123);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecione um tipo de inserção";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnPessoaDoc;
        private System.Windows.Forms.Button btnPessoa;
    }
}

