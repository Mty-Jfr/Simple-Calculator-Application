using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator_Application
{
    public partial class Form1 : Form
    {
        ICalculate calculate;
        public Form1()
        {
            InitializeComponent();
            calculate = new Calculate();
        }

        bool ValidateInpute()
        {

            bool inValid = true;

            if (txtnumber1.Value == 0 || txtnumber2.Value == 0)
            {
                inValid = false;
                MessageBox.Show("لطفاعدد هارا وارد کنید");
            }
            return inValid;

        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            if (ValidateInpute())
            {
                int sum = calculate.plus((int)txtnumber1.Value , (int) txtnumber2.Value);
                MessageBox.Show("sum Is : " + sum);
            }
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            if (ValidateInpute())
            {
                int minus = calculate.minus((int)txtnumber1.Value, (int)txtnumber2.Value);
                MessageBox.Show("minus Is : " + minus);
            }
        }

        private void btnmultiple_Click(object sender, EventArgs e)
        {
            if (ValidateInpute())
            {
                int multiple = calculate.multiple((int)txtnumber1.Value, (int)txtnumber2.Value);
                MessageBox.Show("multiple Is : " + multiple);
            }
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            if (ValidateInpute())
            {
                int divide = calculate.divide((int)txtnumber1.Value, (int)txtnumber2.Value);
                MessageBox.Show("Divide Is : " + divide);
            }
        }
    }
}
