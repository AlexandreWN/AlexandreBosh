using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FifaAplication
{
    public partial class TelaPrincipal : Form
    {
        string usuario;
        public TelaPrincipal(string email)
        {
            InitializeComponent();
            usuario = email;
            lbUsuario.Text = email;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbFoto_Click(object sender, EventArgs e)
        {
            Perfil newUser = new Perfil(usuario);
            newUser.Show();
            this.Hide();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnConvidados_Click(object sender, EventArgs e)
        {
            Convidados convidados = new Convidados(usuario);
            convidados.Show();
            this.Hide();
        }
    }
}
