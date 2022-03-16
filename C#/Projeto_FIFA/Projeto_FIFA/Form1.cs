using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_FIFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Set to no text.
            textBox1.Text = "";
            // The password character is an asterisk.
            textBox1.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            textBox1.MaxLength = 14;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
