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
using System.IO;

namespace FifaAplication
{
    public partial class NovoUsuario : Form
    {
        public NovoUsuario(string email)
        {
            InitializeComponent();
            txbEmail.Text = email;
            AutoCompleteStringCollection dadosListaTime = new AutoCompleteStringCollection();
            AutoCompleteStringCollection dadosListaCor = new AutoCompleteStringCollection();

            // CRIANDO A CONEXÃO COM O BANCO DE DADOS
            SqlConnection conn = new SqlConnection("Server=CTPC3616;Database=ModuloDesktop;Trusted_Connection=True;");

            // ADICIONA OS DADOS DE TIMES PARA O AUTOCOMPLETE
            SqlCommand comando = new SqlCommand($"Select timeFavorito from Usuarios", conn);
            conn.Open();
            SqlDataReader dataReader = comando.ExecuteReader();
            dataReader.Read();

            while (dataReader.Read())
            {
                dadosListaTime.Add(dataReader[0].ToString());
            }
            conn.Close();


            // ADICIONA OS DADOS DE CORES PARA O AUTOCOMPLETE
            comando = new SqlCommand($"Select corFavorita from Usuarios", conn);
            conn.Open();
            dataReader = comando.ExecuteReader();
            dataReader.Read();

            while (dataReader.Read())
            {
                dadosListaCor.Add(dataReader[0].ToString());
            }
            conn.Close();

            txbTimFav.AutoCompleteCustomSource = dadosListaTime;
            txbCor.AutoCompleteCustomSource = dadosListaCor;



        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=CTPC3616;Database=ModuloDesktop;Trusted_Connection=True;");
            SqlCommand comando = new SqlCommand("SELECT * FROM Usuarios", conn);
            conn.Open();
            bool ver = false;
            if (txbSenha.Text == "" || txbApelido.Text == "" || txbCor.Text == "" || txbTimFav.Text == "" || txbData.Text == "")
            {
                MessageBox.Show("Formulario ainda não pronto");
            }
            else
            {
                SqlDataReader dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {
                    if (txbApelido.Text == (dataReader[4] + ""))
                    {
                        ver = true;
                    }
                }

                conn.Close();
                // cadastro no banco de dados
                if (ver)
                {
                    MessageBox.Show("Apelido já existente!");
                }
                else
                {
                    try { 
                      //Não sei o que ta rolando aqui direito mas funciona
                        byte[] imageData = null;

                        using (var ms = new MemoryStream())
                        {
                            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            imageData = ms.ToArray();
                        }

                        //Abre a conexão
                        conn.Open();
                        comando = new SqlCommand("update Usuarios set Senha = @Senha, Foto = @Foto, apelido = @apelido, timeFavorito = @timeFavorito, corFavorita = @corFavorita, nascimento = @nascimento, DataCadastro = @DataCadastro WHERE Email ='" + txbEmail.Text + "';", conn);

                        //Adiciona como parametro os valores das texts boxes
                        comando.Parameters.AddWithValue("@Senha", txbSenha.Text);
                        comando.Parameters.Add("@Foto", SqlDbType.VarBinary).Value = imageData;
                        comando.Parameters.AddWithValue("@apelido", txbApelido.Text);
                        comando.Parameters.AddWithValue("@timeFavorito", txbTimFav.Text);
                        comando.Parameters.AddWithValue("@corFavorita", txbCor.Text);
                        comando.Parameters.AddWithValue("@nascimento", SqlDbType.Date).Value = txbData.Value.Date;
                        comando.Parameters.AddWithValue("@DataCadastro", DateTime.Now.Date);

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Cadastro Realizado com Sucesso!");
                        Login login = new Login(txbEmail.Text);
                        login.Show();
                        this.Hide();
                    }
                catch (SqlException a)
                {
                    throw new Exception(a.Message);
                }
                finally
                {
                    conn.Close();
                }   
                }

            }
        }

        private void txbData_ValueChanged(object sender, EventArgs e)
        {
           
        }

        //escolhe a foto e coloca no pictureBox
        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "jpg|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = file.FileName;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja cancelar o cadastro?", "Cancelar Cadastro", MessageBoxButtons.YesNo);
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

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txbApelido_TextChanged(object sender, EventArgs e)
        {

        }

        private void NovoUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
