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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load_1(object sender, EventArgs e)
        {
            CarregarFuncionario();
            carregarFuncao();
        }
        public void CarregarFuncionario()
        {
            DataSet ds = new DataSet();
            SqlConnection conexao = null;


            try
            {
                conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Prova;Data Source=LAB-06-12");
                conexao.Open();
                SqlCommand cmd = new SqlCommand("sp_RetornarFuncionario", conexao);
                cmd.CommandType = CommandType.StoredProcedure;

                if (txbPesquisar.Text != "")
                {

                    cmd.Parameters.AddWithValue("@nmFuncionario", txbPesquisar.Text);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                //carregar datagrid na tela
                dgvFuncionarios.DataSource = ds.Tables[0];
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


        private void cbEstado_SelectedIndexChanged_1(object sender, EventArgs e)
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



        private void carregarFuncao()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Prova;Data Source=LAB-06-12";
            conexao.Open();

            string comandoSQLs = "SELECT idfuncao,funcao from tbFuncao";

            SqlCommand sqlCommands = new SqlCommand(comandoSQLs, conexao);

            SqlDataAdapter sdas = new SqlDataAdapter(sqlCommands);
            DataTable dts = new DataTable();

            sdas.Fill(dts);

            cbFuncao.DataSource = dts;
            cbFuncao.ValueMember = "idfuncao";
            cbFuncao.DisplayMember = "funcao";


            conexao.Close();

        }

        
       

       

        private void cbFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            carregarEspecialidade();
            
        }


        private void carregarEspecialidade()
        {
            try
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Prova;Data Source=LAB-06-12";
                conexao.Open();

                int numero = int.Parse(cbFuncao.SelectedValue.ToString());


                string comandoSQL = "SELECT* FROM tbEspecialidade where idfuncao = '" + numero + "'";

                SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

                SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                cbEspecialidade.DataSource = dt;
                cbEspecialidade.ValueMember = "idespecialidade";
                cbEspecialidade.DisplayMember = "especialidade";


                conexao.Close();
            }
            catch
            { }
            
            
        }

        private void lblSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //conexão com banco
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Prova;Data Source=LAB-06-12";

                //abrir conexão
                conexao.Open();

                //inseri texto de insert
                string insertCliente = string.Concat("insert into tbFuncionario(nome,endereco,telefone,idCidades,idfuncao,idespecialidade) values('" + txbNome.Text + "','" + txbEndereco.Text + "','" + txbTelefone.Text + "'," + int.Parse(cbCidade.SelectedValue.ToString()) + "," + int.Parse(cbFuncao.SelectedValue.ToString()) + "," + int.Parse(cbEspecialidade.SelectedValue.ToString()) + ")");

                //insere texto de insert em nova consulta
                SqlCommand comandaSQL = new SqlCommand(insertCliente, conexao);

                //Tecla F5
                comandaSQL.ExecuteNonQuery();

                MessageBox.Show("Cadastrado!");
                CarregarFuncionario();
            
            //Fechando a Conexão
            conexao.Close();
            }
            catch { }
        }

        private void txbPesquisar_TextChanged_1(object sender, EventArgs e)
        {
            CarregarFuncionario();
        }

        private void btnPesquisa_Click_1(object sender, EventArgs e)
        {
            CarregarFuncionario();
        }

     

       
    }
}
