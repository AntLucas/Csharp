using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void validar() {
            bool result = false;
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=aula13;Data Source=LAB-06-11";
            conexao.Open();

            string comandoSQL = "SELECT * from tbmicrobio where microbio='"+txbNome.Text+"' and senha ='"+txbSenha.Text+"'";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataReader dados = sqlCommand.ExecuteReader();
            result = dados.HasRows;

            if (result)
            {
                Form1 fm1 = new Form1();
                fm1.Show();

            }

            else { 
            MessageBox.Show("C");
            }


         }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            validar();
        }
    }
}
