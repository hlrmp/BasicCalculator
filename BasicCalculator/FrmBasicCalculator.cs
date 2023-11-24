using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatePrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
            operators();
        }

        public void operators()
        {
            ArrayList array = new ArrayList();
            array.Add("-");
            array.Add("+");
            array.Add("*");
            array.Add("/");

            foreach (string op in array)
            {
                cbOperator.Items.Add(op);
            }
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            float num1 = Convert.ToInt32(txt1.Text);
            float num2 = Convert.ToInt32(txt2.Text);
            float total;

            if(cbOperator.Text.ToString().Equals("+"))
            {
                total = BasicComputation.Addition(num1, num2);
                lblanswer.Text = total.ToString();
            }
           else if (cbOperator.Text.ToString().Equals("-"))
            {
                total = BasicComputation.Substraction(num1, num2);
                lblanswer.Text = total.ToString();
            }
           else if (cbOperator.Text.ToString().Equals("*"))
            {
                total = BasicComputation.Multiplication(num1, num2);
                lblanswer.Text = total.ToString();
            }
            else if (cbOperator.Text.ToString().Equals("/"))
            {
                total = BasicComputation.Division(num1, num2);
                lblanswer.Text = total.ToString();
            }


        }

       
    }
}
