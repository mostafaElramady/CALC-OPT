using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCOPT
{
    public partial class Form1 : Form
    {


        double result = 0;
        string Operation_performed = "";
        bool isClicked = false;
        public Form1()
        {


            InitializeComponent();
        }

        private void TxtBox_Result_TextChanged(object sender, EventArgs e)

        {


        }

        private void c(object sender, EventArgs e)
        {

        }

        private void Button_click1(object sender, EventArgs e)
        {
            if ((TxtBox_Result.Text == "0") || (isClicked  ) )
            {
                TxtBox_Result.Clear();
            }

            isClicked = false;
            Button button = (Button)sender;
            if (button.Text== ".")
            {
                if (!TxtBox_Result.Text.Contains("."))
                {
                    TxtBox_Result.Text = TxtBox_Result.Text + button.Text;
                }
            }

            else
            {
                TxtBox_Result.Text = TxtBox_Result.Text + button.Text;
            }
            
      
         

        }

        private void operatoin(object sender, EventArgs e)
        {
            Button button = (Button)sender;
          
                Operation_performed = button.Text;
                result = Convert.ToDouble(TxtBox_Result.Text);
                currentopt.Text = result + " " + Operation_performed;

                isClicked = true;
            
             

        }

        private void button16_Click(object sender, EventArgs e)
        {
            TxtBox_Result.Clear();
           
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            switch (Operation_performed)
            {
                case "+" :
                    TxtBox_Result.Text = (result + double.Parse(TxtBox_Result.Text)).ToString();
                    break;

                case "-":
                    TxtBox_Result.Text = (result - double.Parse(TxtBox_Result.Text)).ToString();
                    break;
                case "X":
                    TxtBox_Result.Text = (result * double.Parse(TxtBox_Result.Text)).ToString();
                    break;
                case "/":
                    TxtBox_Result.Text = (result / double.Parse(TxtBox_Result.Text)).ToString();
                    break;
                default:
                    break;

                   

                   
          
            }

           
        }

        private void currentopt_Click(object sender, EventArgs e)
        {

        }
    }
}

