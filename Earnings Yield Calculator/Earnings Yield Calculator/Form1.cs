using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CIS_4620_Financial_IT_Assignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
           
            // Declaring variables for calculations
            double calcProfit;
            double calcSharePrice;
            double calcSharesOutstanding;
            
            double calcEarningPerShares;
            double calcEarningYields;

            try
            {
                // If Mode 2 is being calculated
                if ((profit.Text == String.Empty) || (sharesOutstanding.Text == String.Empty))
                {
                    // Obtaining the Text property of the profit, sharesOutstanding, sharePrice
                    // Converting to a double
                    calcSharePrice = Convert.ToDouble(sharePrice.Text);
                    calcEarningPerShares = Convert.ToDouble(earningsPerShare.Text);

                    // Code for calculations
                    calcEarningYields = (calcEarningPerShares / calcSharePrice) * 100;
                }

                // If Mode 1 is being calculated
                else
                {
                    // Obtaining the Text property of the profit, sharesOutstanding, sharePrice
                    // Converting to a double
                    calcProfit = Convert.ToDouble(profit.Text);
                    calcSharePrice = Convert.ToDouble(sharePrice.Text);
                    calcSharesOutstanding = Convert.ToDouble(sharesOutstanding.Text);

                    // Code for calculations
                    calcEarningPerShares = calcProfit / calcSharesOutstanding;
                    calcEarningYields = (calcEarningPerShares / calcSharePrice) * 100;
                }

                // Convert final results from double back to String
                earningsPerShare.Text = String.Format("{0:N2}", calcEarningPerShares);
                earningsYield.Text = String.Format("{0:N2}", calcEarningYields);
            }

            catch (Exception ex)
            {
                // If values are not provided
                MessageBox.Show("Exception: " + ex.Message);
            }             
        }       
    }
}
