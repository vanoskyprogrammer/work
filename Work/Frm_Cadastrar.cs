using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Work
{
    public partial class Frm_Cadastrar : Form
    {
        public Frm_Cadastrar()
        {
            InitializeComponent();
        }
        string PP = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Biblioteca;Data Source=DESKTOP-5N8ECQI\SQLEXPRESS";
        private void bnt_cadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(PP);
            SqlDataAdapter Cmd = new SqlDataAdapter();
            // Código para inserir dados na base de dados a partir do C#
            Cmd.InsertCommand = new SqlCommand("INSERT INTO Utilizador VALUES(@Nome,@User,@Senha,@Funcao)", conn);
            // Paramentros dos campos que existe na base de dados 
            Cmd.InsertCommand.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txt_nome.Text;
            Cmd.InsertCommand.Parameters.Add("@User", SqlDbType.VarChar).Value = txt_user.Text;
            Cmd.InsertCommand.Parameters.Add("@Senha", SqlDbType.VarChar).Value = txt_senha.Text;
            Cmd.InsertCommand.Parameters.Add("@Funcao", SqlDbType.VarChar).Value = cbm_funcao.Text;
            try
            {
                conn.Open();
                Cmd.InsertCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Usuario cadastrado com sucesso");
                txt_nome.Text = "";
                txt_user.Text = "";
                txt_senha.Text = "";
                cbm_funcao.Text = "";
                txt_nome.Focus();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Cadastrar o Usuario" + erro);

            }
        }

        private void bnt_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nome.Text == "")
                {
                    MessageBox.Show("É obrigatório inserir o seu nome para remover valores na sua lista de contacto");
                    txt_nome.Focus();
                }
                else
                {
                    SqlConnection conn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Biblioteca;Data Source=DESKTOP-5N8ECQI\SQLEXPRESS");
  

                    string sql= "Select * from Utilizador where Nome=@Nome ";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Nome", txt_nome.Text);
                    SqlDataAdapter da;
                    da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_dados.DataSource = dt;

                    conn.Close();
                    MessageBox.Show("pesquisou com Sucesso");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não  pesquisou " + erro.Message);
            }
        }

        private void Remover_bnt_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id.Text == "")
                {
                    MessageBox.Show("É obrigatório inserir o seu nome para remover valores na sua lista de contacto");
                    txt_nome.Focus();
                }
                else
                {

                    SqlConnection conn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Biblioteca;Data Source=DESKTOP-5N8ECQI\SQLEXPRESS");
                    string sql = "delete from Utilizador where  Id =@Id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Id", txt_id.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    MessageBox.Show("valor Removido com Sucesso");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não Removeu porque " + erro.Message);
            }
        }

        private void bnt_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id.Text == "")
                {
                    MessageBox.Show("É obrigatório inserir o seu nome para remover valores na sua lista de contacto");
                    txt_nome.Focus();
                }
                else
                {
                    SqlConnection conn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Biblioteca;Data Source=DESKTOP-5N8ECQI\SQLEXPRESS");

                    string sql = "UPDATE Utilizador set Username=@Username, Nome=@Nome,Senha=@Senha, Funcao=@Funcao where ID=@ID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = txt_id.Text;
                    cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = txt_user.Text;
                    cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txt_nome.Text;
                    cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = txt_senha.Text;
                    cmd.Parameters.Add("@Funcao", SqlDbType.VarChar).Value =cbm_funcao.Text;

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("valor editado com Sucesso");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não Removeu porque " + erro.Message);
            }
        }
    }
}
