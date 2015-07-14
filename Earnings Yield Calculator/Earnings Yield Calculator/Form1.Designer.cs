namespace CIS_4620_Financial_IT_Assignment_1
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
            this.calculate = new System.Windows.Forms.Button();
            this.sharesOutstanding = new System.Windows.Forms.TextBox();
            this.earningsPerShare = new System.Windows.Forms.TextBox();
            this.sharePrice = new System.Windows.Forms.TextBox();
            this.profit = new System.Windows.Forms.TextBox();
            this.earningsYield = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(40, 295);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(367, 39);
            this.calculate.TabIndex = 0;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // sharesOutstanding
            // 
            this.sharesOutstanding.Location = new System.Drawing.Point(203, 93);
            this.sharesOutstanding.Name = "sharesOutstanding";
            this.sharesOutstanding.Size = new System.Drawing.Size(204, 20);
            this.sharesOutstanding.TabIndex = 1;
            // 
            // earningsPerShare
            // 
            this.earningsPerShare.Location = new System.Drawing.Point(203, 142);
            this.earningsPerShare.Name = "earningsPerShare";
            this.earningsPerShare.Size = new System.Drawing.Size(204, 20);
            this.earningsPerShare.TabIndex = 2;
            // 
            // sharePrice
            // 
            this.sharePrice.Location = new System.Drawing.Point(203, 191);
            this.sharePrice.Name = "sharePrice";
            this.sharePrice.Size = new System.Drawing.Size(204, 20);
            this.sharePrice.TabIndex = 3;
            // 
            // profit
            // 
            this.profit.Location = new System.Drawing.Point(203, 44);
            this.profit.Name = "profit";
            this.profit.Size = new System.Drawing.Size(204, 20);
            this.profit.TabIndex = 4;
            // 
            // earningsYield
            // 
            this.earningsYield.Location = new System.Drawing.Point(203, 240);
            this.earningsYield.Name = "earningsYield";
            this.earningsYield.Size = new System.Drawing.Size(204, 20);
            this.earningsYield.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Profit ($)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Shares Outstanding";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Earnings Per Share";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Share Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Earnings Yield";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 361);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.earningsYield);
            this.Controls.Add(this.profit);
            this.Controls.Add(this.sharePrice);
            this.Controls.Add(this.earningsPerShare);
            this.Controls.Add(this.sharesOutstanding);
            this.Controls.Add(this.calculate);
            this.Name = "Form1";
            this.Text = "Earnings Yield Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox sharesOutstanding;
        private System.Windows.Forms.TextBox earningsPerShare;
        private System.Windows.Forms.TextBox sharePrice;
        private System.Windows.Forms.TextBox profit;
        private System.Windows.Forms.TextBox earningsYield;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

