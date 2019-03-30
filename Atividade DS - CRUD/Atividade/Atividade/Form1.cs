using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace insert_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPessoa_Click(object sender, EventArgs e)
        {
            frmPessoa p = new frmPessoa();
            p.Show();
        }

        private void btnPessoaDoc_Click_1(object sender, EventArgs e)
        {
            frmPessoaDoc pd = new frmPessoaDoc();
            pd.Show();
        }

        private void btnFuncionario_Click_1(object sender, EventArgs e)
        {
            frmFuncionario f = new frmFuncionario();
            f.Show();
        }

        private void btnCliente_Click_1(object sender, EventArgs e)
        {
            frmCliente c = new frmCliente();
            c.Show();
        }
    }
}
