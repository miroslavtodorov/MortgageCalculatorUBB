namespace Mortgage_Calculator_UBB
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SelfFund = new System.Windows.Forms.TextBox();
            this.TotalPaid = new System.Windows.Forms.TextBox();
            this.Monthly = new System.Windows.Forms.TextBox();
            this.CreditAmount = new System.Windows.Forms.TextBox();
            this.EurText = new System.Windows.Forms.TextBox();
            this.BGNText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mortgage_Calculator_UBB.Properties.Resources.UBB_logo;
            this.pictureBox1.Location = new System.Drawing.Point(26, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 152);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(87, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(725, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "КАЛКУЛАТОР ЗА ИПОТЕЧНИ КРЕДИТИ КЪМ ОББ АД\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(212, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цена на имота в EUR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(212, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Цена на имота в BGN";
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(685, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 165);
            this.button1.TabIndex = 4;
            this.button1.Text = "ИЗЧИСЛИ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Calculate_click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(685, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 67);
            this.button2.TabIndex = 5;
            this.button2.Text = "ПРЕВАЛУТИРАЙ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.exchangebtn_click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(266, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "САМОУЧАСТИЕ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(274, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "СУМА КРЕДИТ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(235, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "МЕСЕЧНА ВНОСКА";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(198, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "ОБЩО ВЪРНАТА СУМА";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(623, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "EUR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(623, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "BGN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(623, 412);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "BGN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(623, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 23);
            this.label11.TabIndex = 19;
            this.label11.Text = "BGN";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(623, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 23);
            this.label12.TabIndex = 20;
            this.label12.Text = "BGN";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(623, 270);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 23);
            this.label13.TabIndex = 21;
            this.label13.Text = "BGN";
            // 
            // SelfFund
            // 
            this.SelfFund.Font = new System.Drawing.Font("Arial", 12F);
            this.SelfFund.Location = new System.Drawing.Point(435, 267);
            this.SelfFund.Name = "SelfFund";
            this.SelfFund.Size = new System.Drawing.Size(182, 26);
            this.SelfFund.TabIndex = 22;
            this.SelfFund.Text = "0.00";
            this.SelfFund.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalPaid
            // 
            this.TotalPaid.Font = new System.Drawing.Font("Arial", 12F);
            this.TotalPaid.Location = new System.Drawing.Point(435, 409);
            this.TotalPaid.Name = "TotalPaid";
            this.TotalPaid.Size = new System.Drawing.Size(182, 26);
            this.TotalPaid.TabIndex = 23;
            this.TotalPaid.Text = "0.00";
            this.TotalPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Monthly
            // 
            this.Monthly.Font = new System.Drawing.Font("Arial", 12F);
            this.Monthly.Location = new System.Drawing.Point(435, 362);
            this.Monthly.Name = "Monthly";
            this.Monthly.Size = new System.Drawing.Size(182, 26);
            this.Monthly.TabIndex = 24;
            this.Monthly.Text = "0.00";
            this.Monthly.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CreditAmount
            // 
            this.CreditAmount.Font = new System.Drawing.Font("Arial", 12F);
            this.CreditAmount.Location = new System.Drawing.Point(435, 315);
            this.CreditAmount.Name = "CreditAmount";
            this.CreditAmount.Size = new System.Drawing.Size(182, 26);
            this.CreditAmount.TabIndex = 25;
            this.CreditAmount.Text = "0.00";
            this.CreditAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EurText
            // 
            this.EurText.Font = new System.Drawing.Font("Arial", 12F);
            this.EurText.Location = new System.Drawing.Point(435, 91);
            this.EurText.Name = "EurText";
            this.EurText.Size = new System.Drawing.Size(182, 26);
            this.EurText.TabIndex = 26;
            this.EurText.Text = "0.00";
            this.EurText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BGNText
            // 
            this.BGNText.Font = new System.Drawing.Font("Arial", 12F);
            this.BGNText.Location = new System.Drawing.Point(435, 135);
            this.BGNText.Name = "BGNText";
            this.BGNText.Size = new System.Drawing.Size(182, 26);
            this.BGNText.TabIndex = 27;
            this.BGNText.Text = "0.00";
            this.BGNText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(204, 203);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(209, 23);
            this.label14.TabIndex = 29;
            this.label14.Text = "СРОК ЗА ИЗПЛАЩАНЕ";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DisplayMember = "(none)";
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1 година",
            "2 години",
            "3 години",
            "4 години",
            "5 години",
            "6 години",
            "7 години",
            "8 години",
            "9 години",
            "10 години",
            "11 години",
            "12 години",
            "13 години",
            "14 години",
            "15 години",
            "16 години",
            "17 години",
            "18 години",
            "19 години",
            "20 години",
            "21 години",
            "22 години",
            "23 години",
            "24 години",
            "25 години",
            "26 години",
            "27 години",
            "28 години",
            "29 години",
            "30 години",
            "31 години",
            "32 години",
            "33 години",
            "34 години",
            "35 години"});
            this.comboBox1.Location = new System.Drawing.Point(435, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 26);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.Tag = "35 години";
            this.comboBox1.Text = "35 години";
            this.comboBox1.ValueMember = "35 години";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 465);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BGNText);
            this.Controls.Add(this.EurText);
            this.Controls.Add(this.CreditAmount);
            this.Controls.Add(this.Monthly);
            this.Controls.Add(this.TotalPaid);
            this.Controls.Add(this.SelfFund);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ипотечен калкулатор към ОББ АД";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox SelfFund;
        private System.Windows.Forms.TextBox TotalPaid;
        private System.Windows.Forms.TextBox Monthly;
        private System.Windows.Forms.TextBox CreditAmount;
        private System.Windows.Forms.TextBox EurText;
        private System.Windows.Forms.TextBox BGNText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

