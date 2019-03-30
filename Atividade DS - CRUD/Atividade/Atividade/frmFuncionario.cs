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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }
        public void cadfunc(int idFuncionario, int idPessoa, string cargo, double salario, int ramal)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=smartCity;Data Source=localhost.\\SQLExpress";
            conn.Open();

            //STRING DE CONEXÃO PARA O LABORATÓRIO (NECESSÁRIO ALTERAR MÁQUINA E LAB)
            //conn.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=smartCity;Data Source=LAB-00-00";

            String insert = String.Concat("insert into funcionario(idFuncionario,idPessoa,cargo,salario,ramal) values ('", idFuncionario, "','", idPessoa, "','", cargo, "','", salario, "','", ramal, "')");
            SqlCommand comandaSQL = new SqlCommand(insert, conn);
            comandaSQL.ExecuteNonQuery();
            conn.Close();

        }

        private void LimparCampos()
        {
            txtIdFuncionario.Text = "";
            txtIdPessoa.Text = "";
            txtCargo.Text = "";
            txtSalario.Text = "";
            txtRamal.Text = "";
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            cadfunc(System.Convert.ToInt16(txtIdFuncionario.Text), System.Convert.ToInt16(txtIdPessoa.Text), txtCargo.Text, System.Convert.ToDouble(txtSalario.Text), System.Convert.ToInt16(txtRamal.Text));
            LimparCampos();
            MessageBox.Show("Registro cadastrado", "Cadastrado");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdFuncionario.Text = "";
            txtIdPessoa.Text = "";
            txtCargo.Text = "";
            txtSalario.Text = "";
            txtRamal.Text = "";
        }
    }
}
