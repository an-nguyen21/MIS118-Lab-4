namespace _2._0
{
    partial class frmIncomeTaxCalc
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
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblTaxOwed = new System.Windows.Forms.Label();
            this.txtTaxableIncome = new System.Windows.Forms.TextBox();
            this.txtTaxOwed = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(56, 72);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(111, 17);
            this.lblIncome.TabIndex = 0;
            this.lblIncome.Text = "Taxable Income:";
            // 
            // lblTaxOwed
            // 
            this.lblTaxOwed.AutoSize = true;
            this.lblTaxOwed.Location = new System.Drawing.Point(56, 139);
            this.lblTaxOwed.Name = "lblTaxOwed";
            this.lblTaxOwed.Size = new System.Drawing.Size(124, 17);
            this.lblTaxOwed.TabIndex = 1;
            this.lblTaxOwed.Text = "Income Tax Owed:";
            // 
            // txtTaxableIncome
            // 
            this.txtTaxableIncome.Location = new System.Drawing.Point(199, 69);
            this.txtTaxableIncome.Name = "txtTaxableIncome";
            this.txtTaxableIncome.Size = new System.Drawing.Size(166, 22);
            this.txtTaxableIncome.TabIndex = 2;
            // 
            // txtTaxOwed
            // 
            this.txtTaxOwed.Location = new System.Drawing.Point(199, 136);
            this.txtTaxOwed.Name = "txtTaxOwed";
            this.txtTaxOwed.ReadOnly = true;
            this.txtTaxOwed.Size = new System.Drawing.Size(166, 22);
            this.txtTaxOwed.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(60, 222);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 33);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(246, 222);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 33);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmIncomeTaxCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 333);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTaxOwed);
            this.Controls.Add(this.txtTaxableIncome);
            this.Controls.Add(this.lblTaxOwed);
            this.Controls.Add(this.lblIncome);
            this.Name = "frmIncomeTaxCalc";
            this.Text = "Income Tax Calculator";
            this.Load += new System.EventHandler(this.frmIncomeTaxCalc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblTaxOwed;
        private System.Windows.Forms.TextBox txtTaxableIncome;
        private System.Windows.Forms.TextBox txtTaxOwed;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

