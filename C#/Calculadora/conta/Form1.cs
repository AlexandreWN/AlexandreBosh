using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conta
{
    public partial class Form1 : Form
    {
        ContaBancaria cont = new ContaBancaria();
        ContaPoupanca con = new ContaPoupanca();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void button1_Click(object sender, EventArgs e)
        {
            
            cont.nomeCliente = textBox2.Text;
            cont.numConta = int.Parse(textBox1.Text);
            con.saldo = float.Parse(textBox3.Text);

        }

        public class ContaBancaria
        {
            public string nomeCliente;
            public int numConta;
            public float saldo;

            public float sacar(float valor)
            {
                float x = 0;
                x = saldo - valor;
                saldo = x;
                return saldo;
            }

            public float depositar(float valor)
            {
                float y = 0;
                y = saldo + valor;
                saldo = y;
                return saldo;
            }
        }
        class ContaPoupanca : ContaBancaria
        {
            public void CalcularNovoSaldo(float taxa)
            {
                float z = saldo * taxa / 100;
                this.saldo = saldo + z;
            }
        }
        class ContaEspecial : ContaBancaria
        {
            float limite = 1000;
            public float SacarLimite(float sac)
            {
                float yz = limite - sac;
                limite = yz;
                return limite;
            }
        }

        public void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(cont.nomeCliente);
            listBox1.Items.Add(cont.numConta);
            listBox1.Items.Add(con.saldo);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.sacar(float.Parse(textBox6.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.depositar(float.Parse(textBox4.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.CalcularNovoSaldo(float.Parse(textBox5.Text));
            listBox1.Items.Add(con.saldo);
        }
    }
}
