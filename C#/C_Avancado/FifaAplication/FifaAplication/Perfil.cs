using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Data.SqlClient;

namespace FifaAplication
{
    public partial class Perfil : Form
    {
        string usuario;
        public Perfil(string email)
        {
            usuario = email;
            InitializeComponent();
            SqlConnection conn = new SqlConnection("Server=CTPC3616;Database=ModuloDesktop;Trusted_Connection=True;");
            SqlCommand comando = new SqlCommand("SELECT * FROM Usuarios where Email= '" + usuario + "'", conn);
            conn.Open();
            try
            {
                SqlDataReader dataReader = comando.ExecuteReader();
                dataReader.Read();

                txbEmail.Text = email;
                txbSenha.Text = dataReader[2].ToString();
                txbApelido.Text = dataReader[4].ToString();
                txbCor.Text = dataReader[6].ToString();
                txbTimFav.Text = dataReader[5].ToString();
                txbData.Text = dataReader[7].ToString();

            }
            catch
            {
                conn.Close();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            byte[] imageData = null;

            using (var ms = new MemoryStream())
            {
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageData = ms.ToArray();
            }

            SqlConnection new_conn = new SqlConnection("Server=CTPC3616;Database=ModuloDesktop;Trusted_Connection=True;");
            new_conn.Open();
            SqlCommand new_comando = new SqlCommand("UPDATE Usuarios SET Senha = @Senha,Foto = @Foto, apelido =  @apelido, timeFavorito = @timeFavorito, corFavorita = @corFavorita, nascimento = @nascimento WHERE Email = '" + usuario + "';", new_conn);
            new_comando.Parameters.AddWithValue("@Senha", txbSenha.Text);
            new_comando.Parameters.Add("@Foto", SqlDbType.VarBinary).Value = imageData;
            new_comando.Parameters.AddWithValue("@apelido", txbApelido.Text);
            new_comando.Parameters.AddWithValue("@timeFavorito", txbTimFav.Text);
            new_comando.Parameters.AddWithValue("@corFavorita", txbCor.Text);
            new_comando.Parameters.AddWithValue("@nascimento", SqlDbType.Date).Value = txbData.Value.Date;

            new_comando.ExecuteNonQuery();
            new_conn.Close();
            MessageBox.Show("Dados Atualizados");
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "jpg|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = file.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja cancelar alteração?", "Cancelar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ValidaEmail validaEmail = new ValidaEmail();
                validaEmail.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
