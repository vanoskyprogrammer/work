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
    public partial class Frm_encomendar : Form
    {
        public Frm_encomendar()
        {
            InitializeComponent();
        }
        string PP = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Biblioteca;Data Source=DESKTOP-5N8ECQI\SQLEXPRESS";

        private void bnt_Encomendar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(PP);
            SqlDataAdapter Cmd = new SqlDataAdapter();
            // Código para inserir dados na base de dados a partir do C#
            Cmd.InsertCommand = new SqlCommand("INSERT INTO Encomenda VALUES(@Nome,@Sobrenome,@Email,@Rua,@Casa,@Cidade,@Quantidade,@Titulo_do_Livro,@Autor,@Editora)", conn);
            // Paramentros dos campos que existe na base de dados 
            Cmd.InsertCommand.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txt_nome.Text;
            Cmd.InsertCommand.Parameters.Add("@Sobrenome", SqlDbType.VarChar).Value = txt_sobrenome.Text;
            Cmd.InsertCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = txt_email.Text;
            Cmd.InsertCommand.Parameters.Add("@Rua", SqlDbType.VarChar).Value = txt_rua.Text;
            Cmd.InsertCommand.Parameters.Add("@Casa", SqlDbType.VarChar).Value = txt_casa.Text;
            Cmd.InsertCommand.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = txt_cidade.Text;
            Cmd.InsertCommand.Parameters.Add("@Quantidade", SqlDbType.VarChar).Value = txt_qntd.Text;
            Cmd.InsertCommand.Parameters.Add("@Titulo_do_Livro", SqlDbType.VarChar).Value =txt_titulo.Text;
            Cmd.InsertCommand.Parameters.Add("@Autor", SqlDbType.VarChar).Value = txt_autor.Text;
            Cmd.InsertCommand.Parameters.Add("@Editora", SqlDbType.VarChar).Value = txt_editora.Text;
            try
            {
                conn.Open();
                Cmd.InsertCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Encomenda cadastrada com sucesso");
                txt_nome.Text = "";
                txt_casa.Text = "";
                txt_cidade.Text = "";
                txt_editora.Text = "";
                txt_email.Text = "";
                txt_qntd.Text = "";
                txt_rua.Text = "";
                txt_sobrenome.Text = "";
                txt_titulo.Text = "";

                txt_nome.Focus();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Cadastrar a encomenda" + erro);

            }
        }
    }
}
