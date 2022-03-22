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


namespace Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=JVLPC0565\\SQLEXPRESS;Database=ModuloDesktop;Trusted_Connection=True;");
            SqlCommand comando = new SqlCommand("SELECT * FROM Usuarios", conn);
            conn.Open();
            bool ver = false;
            SqlDataReader dataReader = comando.ExecuteReader();
            while (dataReader.Read())
            {
                if (textBox1.Text == (dataReader[4] + ""))
                {
                    ver = true;
                }
            }
            if (ver)
            {
                MessageBox.Show("Apelido já existente!");
            }
            else
            {
                MessageBox.Show("Nada");
            }
        }
    }
}
