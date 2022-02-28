namespace Prog3
{
    partial class Prog3Form
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.incomeLbl = new System.Windows.Forms.Label();
            this.incomeTxt = new System.Windows.Forms.TextBox();
            this.filingBox = new System.Windows.Forms.GroupBox();
            this.candidate3RdoBtn = new System.Windows.Forms.RadioButton();
            this.candidate2RdoBtn = new System.Windows.Forms.RadioButton();
            this.candidate1RdoBtn = new System.Windows.Forms.RadioButton();
            this.baselineRdoBtn = new System.Windows.Forms.RadioButton();
            this.calcTaxBtn = new System.Windows.Forms.Button();
            this.marginalRateLbl = new System.Windows.Forms.Label();
            this.marginalRateOutLbl = new System.Windows.Forms.Label();
            this.taxOutLbl = new System.Windows.Forms.Label();
            this.taxLbl = new System.Windows.Forms.Label();
            this.filingBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(48, 11);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(236, 17);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "2020 Candidate Tax Rate Caclulator";
            // 
            // incomeLbl
            // 
            this.incomeLbl.AutoSize = true;
            this.incomeLbl.Location = new System.Drawing.Point(20, 44);
            this.incomeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incomeLbl.Name = "incomeLbl";
            this.incomeLbl.Size = new System.Drawing.Size(149, 17);
            this.incomeLbl.TabIndex = 1;
            this.incomeLbl.Text = "Enter Taxable Income:";
            // 
            // incomeTxt
            // 
            this.incomeTxt.Location = new System.Drawing.Point(180, 41);
            this.incomeTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.incomeTxt.Name = "incomeTxt";
            this.incomeTxt.Size = new System.Drawing.Size(132, 22);
            this.incomeTxt.TabIndex = 2;
            // 
            // filingBox
            // 
            this.filingBox.Controls.Add(this.candidate3RdoBtn);
            this.filingBox.Controls.Add(this.candidate2RdoBtn);
            this.filingBox.Controls.Add(this.candidate1RdoBtn);
            this.filingBox.Controls.Add(this.baselineRdoBtn);
            this.filingBox.Location = new System.Drawing.Point(24, 80);
            this.filingBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filingBox.Name = "filingBox";
            this.filingBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filingBox.Size = new System.Drawing.Size(289, 153);
            this.filingBox.TabIndex = 3;
            this.filingBox.TabStop = false;
            this.filingBox.Text = "Candidate?";
            // 
            // candidate3RdoBtn
            // 
            this.candidate3RdoBtn.AutoSize = true;
            this.candidate3RdoBtn.Enabled = false;
            this.candidate3RdoBtn.Location = new System.Drawing.Point(8, 110);
            this.candidate3RdoBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.candidate3RdoBtn.Name = "candidate3RdoBtn";
            this.candidate3RdoBtn.Size = new System.Drawing.Size(105, 21);
            this.candidate3RdoBtn.TabIndex = 4;
            this.candidate3RdoBtn.Text = "Candidate 3";
            this.candidate3RdoBtn.UseVisualStyleBackColor = true;
            // 
            // candidate2RdoBtn
            // 
            this.candidate2RdoBtn.AutoSize = true;
            this.candidate2RdoBtn.Location = new System.Drawing.Point(8, 81);
            this.candidate2RdoBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.candidate2RdoBtn.Name = "candidate2RdoBtn";
            this.candidate2RdoBtn.Size = new System.Drawing.Size(105, 21);
            this.candidate2RdoBtn.TabIndex = 2;
            this.candidate2RdoBtn.Text = "Candidate 2";
            this.candidate2RdoBtn.UseVisualStyleBackColor = true;
            this.candidate2RdoBtn.CheckedChanged += new System.EventHandler(this.candidate2RdoBtn_CheckedChanged);
            // 
            // candidate1RdoBtn
            // 
            this.candidate1RdoBtn.AutoSize = true;
            this.candidate1RdoBtn.Enabled = false;
            this.candidate1RdoBtn.Location = new System.Drawing.Point(9, 53);
            this.candidate1RdoBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.candidate1RdoBtn.Name = "candidate1RdoBtn";
            this.candidate1RdoBtn.Size = new System.Drawing.Size(105, 21);
            this.candidate1RdoBtn.TabIndex = 1;
            this.candidate1RdoBtn.Text = "Candidate 1";
            this.candidate1RdoBtn.UseVisualStyleBackColor = true;
            this.candidate1RdoBtn.CheckedChanged += new System.EventHandler(this.candidate1RdoBtn_CheckedChanged);
            // 
            // baselineRdoBtn
            // 
            this.baselineRdoBtn.AutoSize = true;
            this.baselineRdoBtn.Checked = true;
            this.baselineRdoBtn.Location = new System.Drawing.Point(9, 25);
            this.baselineRdoBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.baselineRdoBtn.Name = "baselineRdoBtn";
            this.baselineRdoBtn.Size = new System.Drawing.Size(83, 21);
            this.baselineRdoBtn.TabIndex = 0;
            this.baselineRdoBtn.TabStop = true;
            this.baselineRdoBtn.Text = "Baseline";
            this.baselineRdoBtn.UseVisualStyleBackColor = true;
            // 
            // calcTaxBtn
            // 
            this.calcTaxBtn.Location = new System.Drawing.Point(112, 254);
            this.calcTaxBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calcTaxBtn.Name = "calcTaxBtn";
            this.calcTaxBtn.Size = new System.Drawing.Size(111, 28);
            this.calcTaxBtn.TabIndex = 4;
            this.calcTaxBtn.Text = "Calculate Tax";
            this.calcTaxBtn.UseVisualStyleBackColor = true;
            this.calcTaxBtn.Click += new System.EventHandler(this.calcTaxBtn_Click);
            // 
            // marginalRateLbl
            // 
            this.marginalRateLbl.AutoSize = true;
            this.marginalRateLbl.Location = new System.Drawing.Point(43, 299);
            this.marginalRateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.marginalRateLbl.Name = "marginalRateLbl";
            this.marginalRateLbl.Size = new System.Drawing.Size(127, 17);
            this.marginalRateLbl.TabIndex = 5;
            this.marginalRateLbl.Text = "Marginal Tax Rate:";
            // 
            // marginalRateOutLbl
            // 
            this.marginalRateOutLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.marginalRateOutLbl.Location = new System.Drawing.Point(180, 298);
            this.marginalRateOutLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.marginalRateOutLbl.Name = "marginalRateOutLbl";
            this.marginalRateOutLbl.Size = new System.Drawing.Size(133, 24);
            this.marginalRateOutLbl.TabIndex = 6;
            // 
            // taxOutLbl
            // 
            this.taxOutLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxOutLbl.Location = new System.Drawing.Point(180, 336);
            this.taxOutLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taxOutLbl.Name = "taxOutLbl";
            this.taxOutLbl.Size = new System.Drawing.Size(133, 24);
            this.taxOutLbl.TabIndex = 8;
            this.taxOutLbl.Text = "--------------";
            this.taxOutLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxLbl
            // 
            this.taxLbl.AutoSize = true;
            this.taxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLbl.Location = new System.Drawing.Point(84, 337);
            this.taxLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taxLbl.Name = "taxLbl";
            this.taxLbl.Size = new System.Drawing.Size(84, 17);
            this.taxLbl.TabIndex = 7;
            this.taxLbl.Text = "Income Tax:";
            // 
            // Prog3Form
            // 
            this.AcceptButton = this.calcTaxBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 377);
            this.Controls.Add(this.taxOutLbl);
            this.Controls.Add(this.taxLbl);
            this.Controls.Add(this.marginalRateOutLbl);
            this.Controls.Add(this.marginalRateLbl);
            this.Controls.Add(this.calcTaxBtn);
            this.Controls.Add(this.filingBox);
            this.Controls.Add(this.incomeTxt);
            this.Controls.Add(this.incomeLbl);
            this.Controls.Add(this.titleLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Prog3Form";
            this.Text = "Program 3";
            this.filingBox.ResumeLayout(false);
            this.filingBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label incomeLbl;
        private System.Windows.Forms.TextBox incomeTxt;
        private System.Windows.Forms.GroupBox filingBox;
        private System.Windows.Forms.RadioButton candidate3RdoBtn;
        private System.Windows.Forms.RadioButton candidate2RdoBtn;
        private System.Windows.Forms.RadioButton candidate1RdoBtn;
        private System.Windows.Forms.RadioButton baselineRdoBtn;
        private System.Windows.Forms.Button calcTaxBtn;
        private System.Windows.Forms.Label marginalRateLbl;
        private System.Windows.Forms.Label marginalRateOutLbl;
        private System.Windows.Forms.Label taxOutLbl;
        private System.Windows.Forms.Label taxLbl;
    }
}

