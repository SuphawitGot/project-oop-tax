namespace taxcalculator
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
            this.txtYearpaid = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtYearpaid
            // 
            this.txtYearpaid.Location = new System.Drawing.Point(312, 67);
            this.txtYearpaid.Name = "txtYearpaid";
            this.txtYearpaid.Size = new System.Drawing.Size(100, 20);
            this.txtYearpaid.TabIndex = 0;
            this.txtYearpaid.TextChanged += new System.EventHandler(this.txtYearpaid_TextChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblYear.Location = new System.Drawing.Point(200, 67);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(83, 18);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "ใส่รายได้ต่อปี";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtYearpaid);
            this.Name = "Form1";
            this.Text = "ะำ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYearpaid;
        private System.Windows.Forms.Label lblYear;
    }
}

