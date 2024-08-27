using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CaluladoraWindowsForms
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operador;
        public Calculadora()
        {
            InitializeComponent();
        }
        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsResta obj2 = new Clases.ClsResta();
        Clases.Clsmultiplicar obj3 = new Clases.Clsmultiplicar();
        Clases.ClsDividir obj4 = new Clases.ClsDividir();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "4";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "0";
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "1";
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "2";
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "3";
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "6";
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "7";
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "8";
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "9";
        }

        private void btnNSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(txtScreen.Text);
            txtScreen.Clear();
        }

        private void btnNresta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(txtScreen.Text);
            txtScreen.Clear();
        }

        private void btnNultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "X";
            primero = double.Parse(txtScreen.Text);
            txtScreen.Clear();
        }

        private void btnN1Division_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(txtScreen.Text);
            txtScreen.Clear();
        }

        private void btnNPunto_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + ".";
        }

        private void btnNIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(txtScreen.Text);
            double sum;
            double res;
            double mult;
            double div;

            switch (operador)
            {
                case "+":
                    sum = obj.Sumar(primero, segundo);
                    txtScreen.Text = sum.ToString();
                    break;
                case "-":
                    res = obj2.Restar(primero, segundo);
                    txtScreen.Text = res.ToString();
                    break;
                
                case "X":
                    mult = obj3.Multiplicar(primero, segundo);
                    txtScreen.Text = mult.ToString();
                    break;
                case "/":
                    div = obj4.Dividir(primero, segundo);
                    txtScreen.Text = div.ToString();
                    break;
            }
        }

        private void btnNCE_Click(object sender, EventArgs e)
        {
            txtScreen.Clear();
        }
      
        private void btnNflecha_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text.Length == 1)
                txtScreen.Text = "";
            else
                txtScreen.Text = txtScreen.Text.Substring(0, txtScreen.Text.Length - 1);
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "5";
        }
    }
}

            