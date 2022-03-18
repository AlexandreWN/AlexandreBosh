using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace FifaAplication
{
    public partial class ValidaEmail : Form
    {
        public ValidaEmail()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=CTPC3616;Database=ModuloDesktop;Trusted_Connection=True;");           
            SqlCommand comando = new SqlCommand("SELECT * FROM Usuarios WHERE Email = '" + txbEmail.Text + "'", conn);
            conn.Open();
            try
            {
                SqlDataReader dataReader = comando.ExecuteReader();
                if (dataReader.Read() == true)
                {
                    Login login = new Login(txbEmail.Text);

                    if (dataReader[9].ToString() == "")
                    {
                        MessageBox.Show("Usuario não cadastrado");
                        NovoUsuario novoUsuario = new NovoUsuario(txbEmail.Text);
                        novoUsuario.Show();
                        this.Hide();
                    }
                    
                    else
                    {
                        login.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Email não encontrado!");
                    txbEmail.Text = "";
                }



            }
            catch (Exception)
            {
                MessageBox.Show("Erro de conexão!");
            }
            finally
            {
                conn.Close();
            }




        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
