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
    public partial class frmPessoaDoc : Form
    {
        public frmPessoaDoc()
        {
            InitializeComponent();
        }

        public void cadDocpessoa(int idPessoa, string rgPessoa, string cpfPessoa, string reservista, string carteiraTrabalho, string cnh)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=smartCity;Data Source=localhost.\\SQLExpress";
            conn.Open();

            //STRING DE CONEXÃO PARA O LABORATÓRIO (NECESSÁRIO ALTERAR MÁQUINA E LAB)
            //conn.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=smartCity;Data Source=LAB-00-00";


            String insert = String.Concat("insert into pessoaDoc(idPessoa ,rgPessoa ,cpfPessoa ,reservista ,carteiraTrabalho,cnh) values ('", idPessoa, "','", rgPessoa, "','", cpfPessoa, "','", reservista, "','", carteiraTrabalho,"','",cnh,"')");
            SqlCommand comandaSQL = new SqlCommand(insert, conn);
            comandaSQL.ExecuteNonQuery();
            conn.Close();
        }
            private void limparCampos()
            {
            txtIdPessoa.Text = "";
            txtRg.Text = "";
            txtCpf.Text = "";
            textBox4.Text = "";
            txtCarteiraTrabalho.Text = "";
            txtCnh.Text = "";
            }

            private void btnCadastrar_Click_1(object sender, EventArgs e)
            {
                cadDocpessoa(System.Convert.ToInt16(txtIdPessoa.Text), txtRg.Text, txtCpf.Text, textBox4.Text, txtCarteiraTrabalho.Text, txtCnh.Text);
                limparCampos();
                MessageBox.Show("Registro cadastrado", "Cadastrado");
            }

            private void btnLimpar_Click_1(object sender, EventArgs e)
            {
                txtIdPessoa.Text = "";
                txtRg.Text = "";
                txtCpf.Text = "";
                textBox4.Text = "";
                txtCarteiraTrabalho.Text = "";
                txtCnh.Text = "";
            }

        
    }
}
