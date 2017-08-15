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
        
        public Form1()

        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e) { }
        private void exchangebtn_click(object sender, EventArgs e)
        {
            Double Euro = 1.95581;
            Double EurAmount = Double.Parse(EurText.Text);
            Double leva = EurAmount * Euro;

            EurText.Text = EurAmount.ToString("### ### ### ###.00");
            BGNText.Text = leva.ToString("### ### ### ###.00");
        }

        private void Calculate_click(object sender, EventArgs e)
        {
            Double Leva = Double.Parse(BGNText.Text);
            BGNText.Text = Leva.ToString("### ### ### ###.00");

            Double Self = Leva * 0.15;
            SelfFund.Text = Self.ToString("### ### ### ###.00");

            Double Credit = Leva * 0.85;
            CreditAmount.Text = Credit.ToString("### ### ### ###.00");

            Double Vnoska = Credit * 0.0046052;
            Monthly.Text = Vnoska.ToString("### ### ### ###.00");

            Double All = Vnoska * 420;
            TotalPaid.Text = All.ToString("### ### ### ###.00");
        }
    }
}
