using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            Circunferencia c = new Circunferencia(a);
            listBox1.Items.Add(c.GetRaio() * (3.14 * 2));
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double l1 = double.Parse(textBox1.Text);
            double l2 = double.Parse(textBox2.Text);
            Retangulo r1 = new Retangulo(l1, l2);
            l1 = r1.GetLado1();
            l2 = r1.GetLado2();
            double c = l1 * l2;
            listBox1.Items.Add(c);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double l1 = double.Parse(textBox1.Text);
            double l2 = double.Parse(textBox2.Text);
            Retangulo r1 = new Retangulo(l1, l2);
            l1 = r1.GetLado1();
            l2 = r1.GetLado2();
            double c = l1 + l2 + l1 + l2;
            listBox1.Items.Add(c);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double l1 = double.Parse(textBox1.Text);
            double l2 = double.Parse(textBox2.Text);
            Triangulo t = new Triangulo(l1, l2);
            l1 = t.GetBase();
            l2 = t.GetBase2();
            double c = (l1 * l2) / 2;
            listBox1.Items.Add(c);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }


    class Circunferencia
    {
        double raio;
        public Circunferencia(double raio)
        {
            this.raio = raio;
        }
        public double GetRaio()
        {
            return raio;
        }
        public void SetRaio(double r)
        {
            this.raio = r;
        }
    }
    class Retangulo
    {
        double lado1;
        double lado2;

        public Retangulo (double lado1, double lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }
        public double GetLado1()
        {
            return lado1;
        }
        public void SetLado1(double l1)
        {
            this.lado1 = l1;
        }
        public double GetLado2()
        {
            return lado2;
        }
        public void SetRaio(double l2)
        {
            this.lado2 = l2;
        }
    }

    class Triangulo
    {
        double base1;
        double base2;

        public Triangulo (double base1, double base2)
        {
            this.base1 = base1;
            this.base2 = base2;

           
        }
        public double GetBase()
        {
            return base1;
        }
        public void SetBase(double b1)
        {
            this.base1 = b1;
        }
        public double GetBase2()
        {
            return base2;
        }
        public void SetBase2(double b2)
        {
            this.base2 = b2;
        }
    }
    
}
