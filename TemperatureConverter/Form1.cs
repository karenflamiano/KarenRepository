using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemperatureConverter.ServiceReference1;

namespace TemperatureConverter
{
    public partial class Form1 : Form
    {
        ConvertTemperatureSoapClient ws = new ConvertTemperatureSoapClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double input = double.Parse(textBox1.Text);
            textBox2.Text = Math.Round((ws.CelciusToFahrenheit(input)), 3).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double input = double.Parse(textBox1.Text);
            textBox2.Text = Math.Round((ws.CelciusToKelvin(input)), 3).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double input = double.Parse(textBox1.Text);
            textBox2.Text = Math.Round((ws.FahrenheitToCelcius(input)), 3).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            double input = double.Parse(textBox1.Text);
            textBox2.Text = Math.Round((ws.FahrenheitToKelvin(input)), 3).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            double input = double.Parse(textBox1.Text);
            textBox2.Text = Math.Round((ws.KelvinToCelcius(input)), 3).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double input = double.Parse(textBox1.Text);
            textBox2.Text = Math.Round((ws.KelvinToFahrenheit(input)), 3).ToString();
        }
    }
}
