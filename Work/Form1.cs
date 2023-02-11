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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
		string Y = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Biblioteca;Data Source=DESKTOP-5N8ECQI\SQLEXPRESS";

		private void bnt_Logar_Click(object sender, EventArgs e)
        {
			SqlConnection Con = new SqlConnection(Y);
			try
			{
				string Sql = "select * from Utilizador where Username=@Username and Senha=@Senha";
				SqlCommand cmd = new SqlCommand(Sql, Con);
				cmd.Parameters.AddWithValue("@Username", txt_user.Text);
				cmd.Parameters.AddWithValue("@Senha", txt_senha.Text);

				Con.Open();
				SqlDataReader dtr = cmd.ExecuteReader();
				vm.NomeFuncionario1 = txt_user.Text;
				while (dtr.Read())
				{

					this.Hide();
					new Frm_principal().ShowDialog();

					this.Close();
					this.Dispose();
				}
				dtr.Close();
			}

			catch (Exception ex)
			{
				MessageBox.Show("Erro de Inserção : " + ex.Message);
			}
			txt_user.Text = "";
			txt_senha.Text = "";
		}
	}

}
        
