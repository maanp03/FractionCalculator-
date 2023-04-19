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

namespace FractionCalculator
{
    public partial class FractionCalculator : Form 

    {
        public FractionCalculator()
        {
            InitializeComponent();
        }

        private void btnPerform_Click(object sender, EventArgs e)
        {  
                Fraction first = new Fraction(Convert.ToInt32(txtBox1.Text), Convert.ToInt32(txtBox2.Text));
                Fraction second = new Fraction(Convert.ToInt32(txtBox3.Text), Convert.ToInt32(txtBox4.Text));

                if (rbtnSum.Checked == true)
                {
                    Fraction result = Fraction.Add(first, second);
                    txtBox5.Text = result.Numerator.ToString();
                    txtBox6.Text = result.Denominator.ToString();
                }
                else if (rbtnSubtract.Checked == true)
                {
                    Fraction result = Fraction.Subtract(first, second);
                    txtBox5.Text = result.Numerator.ToString();
                    txtBox6.Text = result.Denominator.ToString();
                }
                else if (rbtnMultiply.Checked == true)
                {
                    Fraction result = Fraction.Multiply(first, second);
                    txtBox5.Text = result.Numerator.ToString();
                    txtBox6.Text = result.Denominator.ToString();
                }
                else if (rbtnDivide.Checked == true)
                {
                    Fraction result = Fraction.Divide(first, second);
                    txtBox5.Text = result.Numerator.ToString();
                    txtBox6.Text = result.Denominator.ToString();
                }
            







        }
       private void txtBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar)) 
            {
                return;            
            }
            else
            {
                e.Handled= true;
            }

            
        }

        private void txtBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }

          
        }

        private void txtBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
          
        }

        private void txtBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
           
        }

        private void txtBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void lblFirst_Click(object sender, EventArgs e)
        {

        }

        
    }
}
