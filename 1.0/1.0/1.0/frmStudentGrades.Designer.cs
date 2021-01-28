namespace _1._0
{
    partial class frmStudentGrades
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
            this.lblScore = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.txtScoreInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(78, 106);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(100, 17);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score (0-100):";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(183, 203);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(13, 17);
            this.lblResults.TabIndex = 1;
            this.lblResults.Text = "-";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(392, 100);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(142, 29);
            this.btnValidate.TabIndex = 2;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // txtScoreInput
            // 
            this.txtScoreInput.Location = new System.Drawing.Point(196, 103);
            this.txtScoreInput.Name = "txtScoreInput";
            this.txtScoreInput.Size = new System.Drawing.Size(133, 22);
            this.txtScoreInput.TabIndex = 3;
            // 
            // frmStudentGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 309);
            this.Controls.Add(this.txtScoreInput);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblScore);
            this.Name = "frmStudentGrades";
            this.Text = "Student Grade Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TextBox txtScoreInput;
    }
}

