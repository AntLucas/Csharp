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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void cadMicro(string microbio, int celula, string funcao, string descricao, int iddiferenciacao, string senha)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=aula13;Data Source=LAB-06-11";
            conn.Open();


            String insert = String.Concat("insert into tbmicrobio(microbio,celula,funcao,descricao,iddiferenciacao,idtipo,senha)values ('", microbio, "','", celula, "','", funcao, "','", descricao, "','", iddiferenciacao, "','", idtipo, "','", senha, "')");
            SqlCommand comandaSQL = new SqlCommand(insert, conn);
            comandaSQL.ExecuteNonQuery();
            conn.Close();
        }

        public void limparCampos() {
            txbFuncao.Text = "";
            txbNome.Text = "";
            txbNumero.Text = "";
            txbDesc.Text = "";
            txbSenha.Text = "";
           
        }



     

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void retornarTipos()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=aula13;Data Source=LAB-06-11";
            conexao.Open();

            //idAluno, rgAluno, cpfAluno, dsEndereco, nmAluno, foneAluno, curso
            string comandoSQL = "SELECT * from tbdiferenciacao";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            cbxtipo.DataSource = dt;
            cbxtipo.DisplayMember = "tipo";
            cbxtipo.ValueMember = "iddiferenciacao";

            conexao.Close();
        }

        private void cbxtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
          

            string ObterTextoCombo = cbxtipo.SelectedItem.ToString();
           
            carregarDiferencas(ObterTextoCombo);
        }

        

        private void carregarDiferencas(string ObterTextoCombo)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=aula13;Data Source=LAB-06-11";
            conexao.Open();

            string comandoSQL = "SELECT diferenciacao FROM tbdiferenciacao where tipo = '" + ObterTextoCombo + "'";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            cbxdiferenciacao.DataSource = dt;

            cbxdiferenciacao.DisplayMember = "diferenciacao";
            cbxdiferenciacao.ValueMember = "iddiferenciacao";

            conexao.Close();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            cadMicro(txbNome.Text,int.Parse(txbNumero.Text),txbFuncao.Text,txbDesc.Text,int.Parse(cbxdiferenciacao.SelectedValue.ToString()),txbSenha.Text);
         
            limparCampos();
            MessageBox.Show("Registro cadastrado", "Cadastrado");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            retornarTipos();
           
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            Form2 Fm2 = new Form2();
            Fm2.Hide();
            Form3 fm3 = new Form3();
            fm3.Show();

           
        }

        
    }
}
