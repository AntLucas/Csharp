using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProvaDsAntonioLucas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void CarregarCliente()
        {
            DataSet ds = new DataSet();
            SqlConnection conexao = null;


            try
            {
                conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Prova;Data Source=LAB-06-12");
                conexao.Open();
                SqlCommand cmd = new SqlCommand("sp_RetornarCliente", conexao);
                cmd.CommandType = CommandType.StoredProcedure;

                if (txbPesquisar.Text != "")
                {

                    cmd.Parameters.AddWithValue("@nmCliente", txbPesquisar.Text);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                //carregar datagrid na tela
                dgvClientes.DataSource = ds.Tables[0];
            }

            catch (Exception e)
            {
                MessageBox.Show("Erro de conexão");
            }

            finally
            {
                conexao.Close();
            }
        }


        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //alteraração
            //obter valor da combo selecionada

            string ObterTextoCombo = cbEstado.SelectedItem.ToString();
            //string obterValue_id_combo = comboBox1.SelectedValue.ToString();

            //Carregar Cidade
            carregarCidade(ObterTextoCombo);
        }

        private void carregarCidade(string ObterTextoCombo)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Prova;Data Source=LAB-06-12";
            conexao.Open();

            string comandoSQL = "SELECT idCidades,cidades FROM tbCidades where estados = '" + ObterTextoCombo + "'";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            cbCidade.DataSource = dt;
            cbCidade.ValueMember = "idCidades";
            cbCidade.DisplayMember = "cidades";
            

            conexao.Close();

           
        }

      

        private void lblSalvar_Click_1(object sender, EventArgs e)
        {
            //conexão com banco
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Prova;Data Source=LAB-06-12";

            //abrir conexão
            conexao.Open();

            //inseri texto de insert
            string insertCliente = string.Concat("insert into tbCliente(nome, endereco, telefone,idCidades) values ('" + txbNome.Text + "', '" + txbEndereco.Text + "','" + txbTelefone.Text + "', '" + int.Parse(cbCidade.SelectedValue.ToString()) + "')");

            //insere texto de insert em nova consulta
            SqlCommand comandaSQL = new SqlCommand(insertCliente, conexao);

            //Tecla F5
            comandaSQL.ExecuteNonQuery();

            MessageBox.Show("Cadastrado!");
            CarregarCliente();
            //Fechando a Conexão
            conexao.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarCliente();
        }

        private void txbPesquisar_TextChanged(object sender, EventArgs e)
        {
            CarregarCliente();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            CarregarCliente();
        }

       
    }
}
