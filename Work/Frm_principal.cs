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
    public partial class Frm_principal : Form
    {
        public Frm_principal()
        {
            InitializeComponent();
        }

        private void Frm_principal_Load(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Biblioteca;Data Source=DESKTOP-5N8ECQI\SQLEXPRESS");
            string sql = "select * from  Utilizador where Username=@Username";
            SqlCommand cmd = new SqlCommand(sql, Con);
            cmd.Parameters.AddWithValue("@Username", vm.NomeFuncionario1);
            Con.Open();
            SqlDataReader dtr = cmd.ExecuteReader();
            while (dtr.Read())
            {
                Utilizador.Text = (string)dtr["Nome"];
                Fun1.Text = (string)dtr["Funcao"];
                codfuncionario.Text = Convert.ToString(dtr["Id"]);
            }
            dtr.Close();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (Fun1.Text == "ADM")
                {
                    new Frm_Cadastrar().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Contactar o Administrador!", "PembeleSoft?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
            }
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_encomendar frm_ = new Frm_encomendar();
            frm_.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja fechar a aplicação?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.SetVisibleCore(true);
            }

        }
    }
}
