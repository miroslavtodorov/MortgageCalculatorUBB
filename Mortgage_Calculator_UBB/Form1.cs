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

            string period;
            period = comboBox1.Text;

            if (period == "35 години")
            {
                Double Interest = 0.0046052;
                Double Months = 12 * 35;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "34 години")
            {
                Double Interest = 0.0046638;
                Double Months = 12 * 34;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "33 години")
            {
                Double Interest = 0.0047268;
                Double Months = 12 * 33;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "32 години")
            {
                Double Interest = 0.0047941;
                Double Months = 12 * 32;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "31 години")
            {
                Double Interest = 0.0048665;
                Double Months = 12 * 31;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "30 години")
            {
                Double Interest = 0.0049447;
                Double Months = 12 * 30;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "29 години")
            {
                Double Interest = 0.0050288;
                Double Months = 12 * 29;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "28 години")
            {
                Double Interest = 0.0051197;
                Double Months = 12 * 28;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "27 години")
            {
                Double Interest = 0.0052182;
                Double Months = 12 * 27;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "26 години")
            {
                Double Interest = 0.0053250;
                Double Months = 12 * 26;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "25 години")
            {
                Double Interest = 0.0054415;
                Double Months = 12 * 25;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "24 години")
            {
                Double Interest = 0.0055685;
                Double Months = 12 * 24;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "23 години")
            {
                Double Interest = 0.0057076;
                Double Months = 12 * 23;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "22 години")
            {
                Double Interest = 0.0058603;
                Double Months = 12 * 22;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "21 години")
            {
                Double Interest = 0.0060288;
                Double Months = 12 * 21;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "20 години")
            {
                Double Interest = 0.0062153;
                Double Months = 12 * 20;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "19 години")
            {
                Double Interest = 0.0064226;
                Double Months = 12 * 19;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "18 години")
            {
                Double Interest = 0.0066544;
                Double Months = 12 * 18;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "17 години")
            {
                Double Interest = 0.0069147;
                Double Months = 12 * 17;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "16 години")
            {
                Double Interest = 0.0072091;
                Double Months = 12 * 16;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "15 години")
            {
                Double Interest = 0.0075447;
                Double Months = 12 * 15;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "14 години")
            {
                Double Interest = 0.0079297;
                Double Months = 12 * 14;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "13 години")
            {
                Double Interest = 0.0083756;
                Double Months = 12 * 13;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "12 години")
            {
                Double Interest = 0.0088982;
                Double Months = 12 * 12;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "11 години")
            {
                Double Interest = 0.0095179;
                Double Months = 12 * 11;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "10 години")
            {
                Double Interest = 0.0102644;
                Double Months = 12 * 10;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "9 години")
            {
                Double Interest = 0.0111791;
                Double Months = 12 * 9;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "8 години")
            {
                Double Interest = 0.0123262;
                Double Months = 12 * 8;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "7 години")
            {
                Double Interest = 0.0138041;
                Double Months = 12 * 7;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "6 години")
            {
                Double Interest = 0.0157791;
                Double Months = 12 * 6;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "5 години")
            {
                Double Interest = 0.0185491;
                Double Months = 12 * 5;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "4 години")
            {
                Double Interest = 0.0227103;
                Double Months = 12 * 4;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "3 години")
            {
                Double Interest = 0.0296544;
                Double Months = 12 * 3;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "2 години")
            {
                Double Interest = 0.0435556;
                Double Months = 12 * 2;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }

            if (period == "1 години")
            {
                Double Interest = 0.0852838;
                Double Months = 12 * 1;
                Double Vnoska = Credit * Interest;
                Monthly.Text = Vnoska.ToString("### ### ### ###.00");
                Double All = Vnoska * Months;
                TotalPaid.Text = All.ToString("### ### ### ###.00");
            }
        }
    }
}