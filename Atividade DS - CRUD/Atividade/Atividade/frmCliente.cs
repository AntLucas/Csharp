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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }
		
		private void cadCli(int idCliente, int idPessoa, DateTime dtInclusao)
        {
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = "Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=smartCity;Data Source=localhost.\\SQLExpress";
			//STRING DE CONEXÃO PARA O LABORATÓRIO (NECESSÁRIO ALTERAR MÁQUINA E LAB)
			//conn.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=smartCity;Data Source=LAB-00-00";
			  
			conn.Open();
			String insert = String.Concat("insert into cliente(idCliente,idPessoa,dtInclusao) values ('", idCliente, "','", idPessoa, "','", dtInclusao, "')");
			SqlCommand comandaSQL = new SqlCommand(insert, conn);
			comandaSQL.ExecuteNonQuery();
			conn.Close();
        }
		
        private void LimparCampos()
        {
			txtIdCliente.Text = "";
			txtIdPessoa.Text = "";
			dateTimePicker1.Text = "";
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            cadCli(System.Convert.ToInt16(txtIdCliente.Text), System.Convert.ToInt16(txtIdPessoa.Text), System.Convert.ToDateTime(dateTimePicker1.Text));
            LimparCampos();
            MessageBox.Show("Registro cadastrado", "Cadastrado");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdCliente.Text = "";
            txtIdPessoa.Text = "";
            dateTimePicker1.Text = "";
        }
    }
}
