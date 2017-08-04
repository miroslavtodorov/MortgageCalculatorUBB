using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mortgage_Calculator_UBB
{
    public partial class Form1 : Form
    {
        Double Euro = 1.95581;

        public Form1()

        {
            InitializeComponent();
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exchangebtn_click(object sender, EventArgs e)
        {
            Double EurAmount = Double.Parse(EurText.Text);
            Double LevaAmount = EurAmount * Euro;

            BGNText.Text = System.Convert.ToString(Math.Round(LevaAmount,2));
        }

        private void Calculate_click(object sender, EventArgs e)
        {
            Double Leva = Double.Parse(BGNText.Text);

            Double Self = Leva * 0.15;
            SelfFund.Text = System.Convert.ToString(Math.Round(Self, 2));

            Double Credit = Leva * 0.85;
            CreditAmount.Text = System.Convert.ToString(Math.Round(Credit, 2));

            Double Vnoska = Credit * 0.0046052;
            Monthly.Text = System.Convert.ToString(Math.Round(Vnoska, 2));

            Double All = Vnoska * 420;
            TotalPaid.Text = System.Convert.ToString(Math.Round(All, 2));
        }
    }
}
