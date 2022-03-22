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
    public partial class Convidados : Form
    {
        string usuario;
        string idUser;
       
        public Convidados(string email)
        {
            usuario = email; 
            InitializeComponent();
            lbUsuario.Text = email;
            MessageBox.Show(email);

            SqlConnection conn = new SqlConnection("Server=CTPC3616;Database=ModuloDesktop;Trusted_Connection=True;");
            SqlCommand comando = new SqlCommand("SELECT IdUsuario FROM Usuarios WHERE Email = '"+email+"'", conn);
            conn.Open();
            try
            {
                SqlDataReader dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {
                    idUser = dataReader[0] + "";
                }
                MessageBox.Show(idUser);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao identificar o usuário!");
            }
            finally
            {
                conn.Close();
            }



        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal(usuario);
            telaPrincipal.Show();
            this.Hide();
        }

        private void btnConvidados_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=CTPC3616;Database=ModuloDesktop;Trusted_Connection=True;");
            SqlCommand comando = new SqlCommand("SELECT email FROM Usuarios WHERE idIndicado = '"+idUser+"'", conn);
            conn.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgridConvidados.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar os convidados!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void Convidados_Load(object sender, EventArgs e)
        {

        }

        private void pbFoto_Click(object sender, EventArgs e)
        {
            Perfil newUser = new Perfil(usuario);
            newUser.Show();
            this.Hide();
        }
    }
}
