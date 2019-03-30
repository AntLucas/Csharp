using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace insert_csharp
{
    public partial class frmPessoa : Form
    {
        public frmPessoa()
        {
            InitializeComponent();
        }
        public void cadpessoa(int idPessoa, string nmPessoa, string dsEndereco, string estCivil, DateTime dtNascimento)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=smartCity;Data Source=localhost.\\SQLExpress";
            conn.Open();

            //STRING DE CONEXÃO PARA O LABORATÓRIO (NECESSÁRIO ALTERAR MÁQUINA E LAB)
            //conn.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=smartCity;Data Source=LAB-00-00";

            String insert = String.Concat("insert into pessoa(idPessoa,nmPessoa,dsEndereco,estCivil,dtNascimento) values ('", idPessoa, "','", nmPessoa, "','", dsEndereco, "','", estCivil, "','", dtNascimento, "')");
            SqlCommand comandaSQL = new SqlCommand(insert, conn);
            comandaSQL.ExecuteNonQuery();
            conn.Close();
        }
        private void limparCampos() {
            txtIdPessoa.Text = "";
            txtDsEndereco.Text = "";
            txtNmPessoa.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadpessoa(System.Convert.ToInt16(txtIdPessoa.Text),txtNmPessoa.Text, txtDsEndereco.Text, cbxEstCivil.Text, System.Convert.ToDateTime(txtDtNascimento.Text));
            limparCampos();
            MessageBox.Show("Registro cadastrado", "Cadastrado");
        }

        private void frmPessoa_Load(object sender, EventArgs e)
        {

        }
    }
}
