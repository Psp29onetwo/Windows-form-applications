using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        int previous;
        private void getDigits(object sender, EventArgs e)
        {
            if (status == true)
            { 
                previous = int.Parse(Screen.Text);
                 Screen.Text = "";
            }
            Screen.Text += ((Button)sender).Text;
        }
        string operatoR;
        bool status = false;
        private void getOperators(object sender, EventArgs e)
        {
            operatoR = ((Button)sender).Text;
            status = true;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            switch (operatoR)
            {
                case "+":
                    Screen.Text = (previous + int.Parse(Screen.Text)).ToString();
                    break;
                case "-":
                    Screen.Text = (previous - int.Parse(Screen.Text)).ToString();
                    break;
                case "X":
                    Screen.Text = (previous * int.Parse(Screen.Text)).ToString();
                    break;
                case "÷":
                    Screen.Text = (previous / int.Parse(Screen.Text)).ToString();
                    break;
                case "%":
                    Screen.Text = (previous % int.Parse(Screen.Text)).ToString();
                    break;
                default:
                    status = true;
                    break;
            }
        }

      
    }
}
