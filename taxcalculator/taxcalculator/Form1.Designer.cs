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
            this.btnRun = new System.Windows.Forms.Button();
            this.Childcheck = new System.Windows.Forms.CheckBox();
            this.txtChildnum = new System.Windows.Forms.TextBox();
            this.lblChild = new System.Windows.Forms.Label();
            this.checkSecurity = new System.Windows.Forms.CheckBox();
            this.porteclidecheck = new System.Windows.Forms.CheckBox();
            this.txtDeduction = new System.Windows.Forms.Label();
            this.SMPCheck = new System.Windows.Forms.CheckBox();
            this.GOCHcheck = new System.Windows.Forms.CheckBox();
            this.rmfsffcheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtYearpaid
            // 
            this.txtYearpaid.Location = new System.Drawing.Point(174, 47);
            this.txtYearpaid.Name = "txtYearpaid";
            this.txtYearpaid.Size = new System.Drawing.Size(100, 20);
            this.txtYearpaid.TabIndex = 0;
            this.txtYearpaid.TextChanged += new System.EventHandler(this.txtYearpaid_TextChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblYear.Location = new System.Drawing.Point(65, 46);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(83, 18);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "ใส่รายได้ต่อปี";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(573, 351);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(137, 54);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "คำนวณภาษี";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // Childcheck
            // 
            this.Childcheck.AutoSize = true;
            this.Childcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Childcheck.Location = new System.Drawing.Point(225, 96);
            this.Childcheck.Name = "Childcheck";
            this.Childcheck.Size = new System.Drawing.Size(87, 17);
            this.Childcheck.TabIndex = 3;
            this.Childcheck.Text = "ลดหย่อนบุตร";
            this.Childcheck.UseVisualStyleBackColor = true;
            this.Childcheck.CheckedChanged += new System.EventHandler(this.Childcheck_CheckedChanged);
            // 
            // txtChildnum
            // 
            this.txtChildnum.Location = new System.Drawing.Point(432, 96);
            this.txtChildnum.Name = "txtChildnum";
            this.txtChildnum.Size = new System.Drawing.Size(77, 20);
            this.txtChildnum.TabIndex = 4;
            // 
            // lblChild
            // 
            this.lblChild.AutoSize = true;
            this.lblChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblChild.Location = new System.Drawing.Point(340, 98);
            this.lblChild.Name = "lblChild";
            this.lblChild.Size = new System.Drawing.Size(86, 13);
            this.lblChild.TabIndex = 5;
            this.lblChild.Text = "กรอกจำนวนบุตร";
            // 
            // checkSecurity
            // 
            this.checkSecurity.AutoSize = true;
            this.checkSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkSecurity.Location = new System.Drawing.Point(225, 119);
            this.checkSecurity.Name = "checkSecurity";
            this.checkSecurity.Size = new System.Drawing.Size(125, 17);
            this.checkSecurity.TabIndex = 6;
            this.checkSecurity.Text = "ลดหย่อนประกันสังคม";
            this.checkSecurity.UseVisualStyleBackColor = true;
            // 
            // porteclidecheck
            // 
            this.porteclidecheck.AutoSize = true;
            this.porteclidecheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.porteclidecheck.Location = new System.Drawing.Point(225, 142);
            this.porteclidecheck.Name = "porteclidecheck";
            this.porteclidecheck.Size = new System.Drawing.Size(93, 17);
            this.porteclidecheck.TabIndex = 7;
            this.porteclidecheck.Text = "ประกันบำนาญ";
            this.porteclidecheck.UseVisualStyleBackColor = true;
            // 
            // txtDeduction
            // 
            this.txtDeduction.AutoSize = true;
            this.txtDeduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtDeduction.Location = new System.Drawing.Point(88, 93);
            this.txtDeduction.Name = "txtDeduction";
            this.txtDeduction.Size = new System.Drawing.Size(105, 18);
            this.txtDeduction.TabIndex = 9;
            this.txtDeduction.Text = "เลือกการลดหย่อน";
            // 
            // SMPCheck
            // 
            this.SMPCheck.AutoSize = true;
            this.SMPCheck.Location = new System.Drawing.Point(225, 165);
            this.SMPCheck.Name = "SMPCheck";
            this.SMPCheck.Size = new System.Drawing.Size(183, 17);
            this.SMPCheck.TabIndex = 10;
            this.SMPCheck.Text = "ลดหย่อนส่วนตัว/คู่สมรส/คนพิการ";
            this.SMPCheck.UseVisualStyleBackColor = true;
            // 
            // GOCHcheck
            // 
            this.GOCHcheck.AutoSize = true;
            this.GOCHcheck.Location = new System.Drawing.Point(225, 189);
            this.GOCHcheck.Name = "GOCHcheck";
            this.GOCHcheck.Size = new System.Drawing.Size(85, 17);
            this.GOCHcheck.TabIndex = 11;
            this.GOCHcheck.Text = "กองทุน กอช.";
            this.GOCHcheck.UseVisualStyleBackColor = true;
            // 
            // rmfsffcheck
            // 
            this.rmfsffcheck.AutoSize = true;
            this.rmfsffcheck.Location = new System.Drawing.Point(225, 213);
            this.rmfsffcheck.Name = "rmfsffcheck";
            this.rmfsffcheck.Size = new System.Drawing.Size(112, 17);
            this.rmfsffcheck.TabIndex = 12;
            this.rmfsffcheck.Text = "กองทุนRMF / SFF";
            this.rmfsffcheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rmfsffcheck);
            this.Controls.Add(this.GOCHcheck);
            this.Controls.Add(this.SMPCheck);
            this.Controls.Add(this.txtDeduction);
            this.Controls.Add(this.porteclidecheck);
            this.Controls.Add(this.checkSecurity);
            this.Controls.Add(this.lblChild);
            this.Controls.Add(this.txtChildnum);
            this.Controls.Add(this.Childcheck);
            this.Controls.Add(this.btnRun);
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
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.CheckBox Childcheck;
        private System.Windows.Forms.TextBox txtChildnum;
        private System.Windows.Forms.Label lblChild;
        private System.Windows.Forms.CheckBox checkSecurity;
        private System.Windows.Forms.CheckBox porteclidecheck;
        private System.Windows.Forms.Label txtDeduction;
        private System.Windows.Forms.CheckBox SMPCheck;
        private System.Windows.Forms.CheckBox GOCHcheck;
        private System.Windows.Forms.CheckBox rmfsffcheck;
    }
}

