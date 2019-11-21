using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApProgLab
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }
        double firstnum, secondnum, result;
        char znak = '+';
        private void Num_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            firstnum = 0; secondnum = 0; result = 0;
            textBox1.Clear();
        }

        private void ButtonSum_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                firstnum += 0;
            }
            else
            {
                firstnum += Double.Parse(textBox1.Text);
            }
            znak = (sender as Button).Text[0];
            label1.Text += textBox1.Text + znak;
            textBox1.Clear();
            
        }
        //private void Difference_Button_Click(object sender, EventArgs e)
        //{
        // if (textBox1.Text == "")
        //{
        //firstnum += 0;
        //}
        //   else
        // {
        //   firstnum -= Double.Parse(textBox1.Text);
        // }
        //    label1.Text += textBox1.Text + "-";
        //  textBox1.Clear();
        //  }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            secondnum = Convert.ToDouble(textBox1.Text);
            switch (znak)
            {
                case '+':
                    result = firstnum + secondnum;
                    break;
                case '-':
                    result = firstnum - secondnum;
                    break;
                case 'x':
                    result = firstnum * secondnum;
                    break;
                case '/':
                    result = firstnum / secondnum;
                    break;
            }
            textBox1.Text = result.ToString();
            label1.Text = "";
        }


    }
}
