using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2ndExercise.ServiceReference1;

namespace _2ndExercise
{
    public partial class Form1 : Form
    {
        _4InputsServiceSoapClient ws = new _4InputsServiceSoapClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input1 = 0;
            bool result1 = Int32.TryParse(textBox1.Text, out input1);
            if (!result1)
            {
                textBox1.Text = "Invalid Input";
            }

            int input2 = 0;
            bool result2 = Int32.TryParse(textBox2.Text, out input2);
            if (!result2)
            {
                textBox2.Text = "Invalid Input";
            }

            int input3 = 0;
            bool result3 = Int32.TryParse(textBox3.Text, out input3);
            if (!result3)
            {
                textBox3.Text = "Invalid Input";
            }

            int input4 = 0;
            bool result4 = Int32.TryParse(textBox4.Text, out input4);
            if (!result4)
            {
                textBox4.Text = "Invalid Input";
            }
            int result = ws.AddFourInputs(input1, input2, input3, input4);

            textBox5.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int input1 = 0;
            bool result1 = Int32.TryParse(textBox1.Text, out input1);
            if (!result1)
            {
                textBox1.Text = "Invalid Input";
            }

            int input2 = 0;
            bool result2 = Int32.TryParse(textBox2.Text, out input2);
            if (!result2)
            {
                textBox2.Text = "Invalid Input";
            }

            int input3 = 0;
            bool result3 = Int32.TryParse(textBox3.Text, out input3);
            if (!result3)
            {
                textBox3.Text = "Invalid Input";
            }

            int input4 = 0;
            bool result4 = Int32.TryParse(textBox4.Text, out input4);
            if (!result4)
            {
                textBox4.Text = "Invalid Input";
            }
           
            int result = ws.AverageFourInputs(input1, input2, input3, input4);

            textBox5.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int input1 = 0;
            bool result1 = Int32.TryParse(textBox1.Text, out input1);
            if (!result1)
            {
                textBox1.Text = "Invalid Input";
            }

            int input2 = 0;
            bool result2 = Int32.TryParse(textBox2.Text, out input2);
            if (!result2)
            {
                textBox2.Text = "Invalid Input";
            }

            int input3 = 0;
            bool result3 = Int32.TryParse(textBox3.Text, out input3);
            if (!result3)
            {
                textBox3.Text = "Invalid Input";
            }

            int input4 = 0;
            bool result4 = Int32.TryParse(textBox4.Text, out input4);
            if (!result4)
            {
                textBox4.Text = "Invalid Input";
            }

            var result = ws.SwapFourInputs(input1, input2, input3, input4);

            textBox5.Text = result[0].ToString() + " "+"," + result[1].ToString() + " " + "," + result[2].ToString() + " " + "," + result[3].ToString();

        }
    }
}
