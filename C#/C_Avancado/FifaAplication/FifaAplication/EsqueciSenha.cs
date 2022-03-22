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
    public partial class EsqueciSenha : Form
    {
        int contador = 1;
        string usuario;
        public EsqueciSenha(string email)
        {
            usuario = email;
            InitializeComponent();
            SqlConnection conn = new SqlConnection("Server=CTPC3616;Database=ModuloDesktop;Trusted_Connection=True;");
            SqlCommand comando = new SqlCommand("SELECT pergunta FROM Pergunta WHERE idPergunta = '" + contador + "' ", conn);
            contador++;
            conn.Open();
            txbResposta.Hide();
            try
            {
                SqlDataReader dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {
                    lbPergunta.Text = dataReader[0] + "";
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

        private void EsqueciSenha_Load(object sender, EventArgs e)
        {

        }

        private void lbPergunta_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
           if (contador > 4)
            {
                ValidaEmail validaEmail = new ValidaEmail();
                MessageBox.Show("Excedeu o número de tentativas!");
                validaEmail.Show();
                this.Hide();

            }
            dtPiker.Hide();
            txbResposta.Show();
            lbPergunta.Text = "";
            InitializeComponent();
            SqlConnection conn = new SqlConnection("Server=CTPC3616;Database=ModuloDesktop;Trusted_Connection=True;");
            SqlCommand comando = new SqlCommand("SELECT pergunta FROM Pergunta WHERE idPergunta = '"+contador+"' ", conn);
            
            conn.Open();
            try
            {
                SqlDataReader dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {
                    lbPergunta.Text =dataReader[0] + "";
                }
                conn.Close();
                conn = new SqlConnection("Server=CTPC3616;Database=ModuloDesktop;Trusted_Connection=True;");
                comando = new SqlCommand("select * from Usuarios where Email = '" + usuario + "'", conn);
                conn.Open();
                SqlDataReader dataReaderResp = comando.ExecuteReader();
                while (dataReaderResp.Read())
                {
                    if (DateTime.Parse(dataReaderResp[0] + "") == dtPiker.Value)
                    {
                        MessageBox.Show("foi");
                    }
                    else
                    {
                        MessageBox.Show("erro");
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
            contador++;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
