using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortMoneyIFStatment
{
    public partial class SortMoney : Form
    {
        public SortMoney()
        {
            InitializeComponent();
        }

        private void btnSortMoney_Click(object sender, EventArgs e)
        {

            // use the textbox value (input value ) to sort the money

            int num100 = Convert.ToInt32(tbxEnterValue.Text) / 100;
            tbxMoney100.Text = num100.ToString();

            if (num100 != 0) // check if there is any hundreds 
            {
                // work out how many hundreds are there
                int t = num100 * 100;

                t = Convert.ToInt32(tbxEnterValue.Text) - t;

                tbxEnterValue.Text = t.ToString();
            }

            int num50 = Convert.ToInt32(tbxEnterValue.Text) / 50;
            tbxMoney50.Text = num50.ToString();


            if (num50 != 0)// check if there is any Fifties
            {
                // work out how many fifties are there
                int t = num50 * 50;

                t = Convert.ToInt32(tbxEnterValue.Text) - t;

                tbxEnterValue.Text = t.ToString();
            }

            int num20 = Convert.ToInt32(tbxEnterValue.Text) / 20;
            tbxMoney20.Text = num20.ToString();

            if (num20 != 0)// check if there is any twenties 
            {
                // work out how many twenties are there
                int t = num20 * 20;

                t = Convert.ToInt32(tbxEnterValue.Text) - t;

                tbxEnterValue.Text = t.ToString();
            }

            int num10 = Convert.ToInt32(tbxEnterValue.Text) / 10;
            tbxMoney10.Text = num10.ToString();

            if (num10 != 0)// check if there is any tens 
            {
                // work out how many tens are there
                int t = num10 * 10;

                t = Convert.ToInt32(tbxEnterValue.Text) - t;

                tbxEnterValue.Text = t.ToString();
            }

            int num5 = Convert.ToInt32(tbxEnterValue.Text) / 5;
            tbxMoney5.Text = num5.ToString();

            if (num5 != 0)// check if there is any fives 
            {
                // work out how many fives are there
                int t = num5 * 5;

                t = Convert.ToInt32(tbxEnterValue.Text) - t;

                tbxEnterValue.Text = t.ToString();
            }


            int num2 = Convert.ToInt32(tbxEnterValue.Text) / 2;
            tbxMoney2.Text = num2.ToString();

            if (num2 != 0)// check if there is any twos 
            {
                // work out how many twos are there
                int t = num2 * 2;

                t = Convert.ToInt32(tbxEnterValue.Text) - t;

                tbxEnterValue.Text = t.ToString();
            }

            int num1 = Convert.ToInt32(tbxEnterValue.Text) / 1;
            tbxMoney1.Text = num1.ToString();

            if (num1 != 0)// check if there is any ones
            {
                // work out how many ones are there
                int t = num1 * 1;

                t = Convert.ToInt32(tbxEnterValue.Text) - t;

                tbxEnterValue.Text = t.ToString();
            }

        }
    }
}
