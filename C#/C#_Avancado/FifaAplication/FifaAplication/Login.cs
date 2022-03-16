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
    public partial class Login : Form
    {
        public Login(string email)
        {
            InitializeComponent();
            txbEmail.Text = email;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection("Server=CTPC3616;Database=ModuloDesktop;Trusted_Connection=True;");
            SqlCommand comando = new SqlCommand("SELECT Senha FROM Usuarios WHERE Email = '" + txbEmail.Text + "'", conn);
            conn.Open();
            try
            {
                SqlDataReader dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {
                    if(txbSenha.Text == (dataReader[0] + ""))
                    {
                        MessageBox.Show("Login realizado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta!");
                        txbSenha.Text = "";
                    }
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
        private void Login_Load(object sender, EventArgs e)
        {
          
        }

        private void lkEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EsqueciSenha esqueciSenha = new EsqueciSenha(txbEmail.Text);
            esqueciSenha.Show();
            this.Hide();
        }
    }
}
