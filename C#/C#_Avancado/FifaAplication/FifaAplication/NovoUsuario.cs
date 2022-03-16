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
    public partial class NovoUsuario : Form
    {
       // SqlConnection conn = new SqlConnection("Server=CTPC3616;Database=ModuloDesktop;Trusted_Connection=True;");
        public NovoUsuario()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {

        }
    }
}
