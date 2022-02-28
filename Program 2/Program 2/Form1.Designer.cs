namespace Program_2
{
    partial class programTwoForm
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
            this.incomeLbl = new System.Windows.Forms.Label();
            this.incomeTxt = new System.Windows.Forms.TextBox();
            this.planChoiceLbl = new System.Windows.Forms.Label();
            this.baselineButton = new System.Windows.Forms.RadioButton();
            this.candidateOneButton = new System.Windows.Forms.RadioButton();
            this.candidateTwoButton = new System.Windows.Forms.RadioButton();
            this.candidateThreeButton = new System.Windows.Forms.RadioButton();
            this.taxRateLbl = new System.Windows.Forms.Label();
            this.taxRateResultLbl = new System.Windows.Forms.Label();
            this.taxOwedLbl = new System.Windows.Forms.Label();
            this.taxOwedResultLbl = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // incomeLbl
            // 
            this.incomeLbl.AutoSize = true;
            this.incomeLbl.Location = new System.Drawing.Point(47, 34);
            this.incomeLbl.Name = "incomeLbl";
            this.incomeLbl.Size = new System.Drawing.Size(99, 17);
            this.incomeLbl.TabIndex = 0;
            this.incomeLbl.Text = "Enter Income: ";
            // 
            // incomeTxt
            // 
            this.incomeTxt.Location = new System.Drawing.Point(184, 29);
            this.incomeTxt.Name = "incomeTxt";
            this.incomeTxt.Size = new System.Drawing.Size(100, 22);
            this.incomeTxt.TabIndex = 1;
            // 
            // planChoiceLbl
            // 
            this.planChoiceLbl.AutoSize = true;
            this.planChoiceLbl.Location = new System.Drawing.Point(47, 92);
            this.planChoiceLbl.Name = "planChoiceLbl";
            this.planChoiceLbl.Size = new System.Drawing.Size(96, 17);
            this.planChoiceLbl.TabIndex = 2;
            this.planChoiceLbl.Text = "Choose Plan: ";
            // 
            // baselineButton
            // 
            this.baselineButton.AutoSize = true;
            this.baselineButton.Location = new System.Drawing.Point(184, 92);
            this.baselineButton.Name = "baselineButton";
            this.baselineButton.Size = new System.Drawing.Size(115, 21);
            this.baselineButton.TabIndex = 3;
            this.baselineButton.TabStop = true;
            this.baselineButton.Text = "Baseline Plan";
            this.baselineButton.UseVisualStyleBackColor = true;
            // 
            // candidateOneButton
            // 
            this.candidateOneButton.AutoSize = true;
            this.candidateOneButton.Location = new System.Drawing.Point(184, 139);
            this.candidateOneButton.Name = "candidateOneButton";
            this.candidateOneButton.Size = new System.Drawing.Size(105, 21);
            this.candidateOneButton.TabIndex = 4;
            this.candidateOneButton.TabStop = true;
            this.candidateOneButton.Text = "Candidate 1";
            this.candidateOneButton.UseVisualStyleBackColor = true;
            // 
            // candidateTwoButton
            // 
            this.candidateTwoButton.AutoSize = true;
            this.candidateTwoButton.Location = new System.Drawing.Point(184, 192);
            this.candidateTwoButton.Name = "candidateTwoButton";
            this.candidateTwoButton.Size = new System.Drawing.Size(105, 21);
            this.candidateTwoButton.TabIndex = 5;
            this.candidateTwoButton.TabStop = true;
            this.candidateTwoButton.Text = "Candidate 2";
            this.candidateTwoButton.UseVisualStyleBackColor = true;
            // 
            // candidateThreeButton
            // 
            this.candidateThreeButton.AutoSize = true;
            this.candidateThreeButton.Location = new System.Drawing.Point(184, 241);
            this.candidateThreeButton.Name = "candidateThreeButton";
            this.candidateThreeButton.Size = new System.Drawing.Size(105, 21);
            this.candidateThreeButton.TabIndex = 6;
            this.candidateThreeButton.TabStop = true;
            this.candidateThreeButton.Text = "Candidate 3";
            this.candidateThreeButton.UseVisualStyleBackColor = true;
            // 
            // taxRateLbl
            // 
            this.taxRateLbl.AutoSize = true;
            this.taxRateLbl.Location = new System.Drawing.Point(359, 34);
            this.taxRateLbl.Name = "taxRateLbl";
            this.taxRateLbl.Size = new System.Drawing.Size(131, 17);
            this.taxRateLbl.TabIndex = 7;
            this.taxRateLbl.Text = "Marginal Tax Rate: ";
            // 
            // taxRateResultLbl
            // 
            this.taxRateResultLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxRateResultLbl.Location = new System.Drawing.Point(496, 34);
            this.taxRateResultLbl.Name = "taxRateResultLbl";
            this.taxRateResultLbl.Size = new System.Drawing.Size(131, 17);
            this.taxRateResultLbl.TabIndex = 8;
            // 
            // taxOwedLbl
            // 
            this.taxOwedLbl.AutoSize = true;
            this.taxOwedLbl.Location = new System.Drawing.Point(359, 92);
            this.taxOwedLbl.Name = "taxOwedLbl";
            this.taxOwedLbl.Size = new System.Drawing.Size(75, 17);
            this.taxOwedLbl.TabIndex = 9;
            this.taxOwedLbl.Text = "Tax Owed:";
            // 
            // taxOwedResultLbl
            // 
            this.taxOwedResultLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxOwedResultLbl.Location = new System.Drawing.Point(496, 92);
            this.taxOwedResultLbl.Name = "taxOwedResultLbl";
            this.taxOwedResultLbl.Size = new System.Drawing.Size(131, 16);
            this.taxOwedResultLbl.TabIndex = 10;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(415, 192);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(94, 23);
            this.calculateButton.TabIndex = 11;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // programTwoForm
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 291);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.taxOwedResultLbl);
            this.Controls.Add(this.taxOwedLbl);
            this.Controls.Add(this.taxRateResultLbl);
            this.Controls.Add(this.taxRateLbl);
            this.Controls.Add(this.candidateThreeButton);
            this.Controls.Add(this.candidateTwoButton);
            this.Controls.Add(this.candidateOneButton);
            this.Controls.Add(this.baselineButton);
            this.Controls.Add(this.planChoiceLbl);
            this.Controls.Add(this.incomeTxt);
            this.Controls.Add(this.incomeLbl);
            this.Name = "programTwoForm";
            this.Text = "Program 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label incomeLbl;
        private System.Windows.Forms.TextBox incomeTxt;
        private System.Windows.Forms.Label planChoiceLbl;
        private System.Windows.Forms.RadioButton baselineButton;
        private System.Windows.Forms.RadioButton candidateOneButton;
        private System.Windows.Forms.RadioButton candidateTwoButton;
        private System.Windows.Forms.RadioButton candidateThreeButton;
        private System.Windows.Forms.Label taxRateLbl;
        private System.Windows.Forms.Label taxRateResultLbl;
        private System.Windows.Forms.Label taxOwedLbl;
        private System.Windows.Forms.Label taxOwedResultLbl;
        private System.Windows.Forms.Button calculateButton;
    }
}

