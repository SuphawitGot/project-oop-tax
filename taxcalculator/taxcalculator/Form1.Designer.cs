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
            this.checkSecurity = new System.Windows.Forms.CheckBox();
            this.porteclidecheck = new System.Windows.Forms.CheckBox();
            this.txtDeduction = new System.Windows.Forms.Label();
            this.SMPCheck = new System.Windows.Forms.CheckBox();
            this.GOCHcheck = new System.Windows.Forms.CheckBox();
            this.rmfsffcheck = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnOBJ = new System.Windows.Forms.Button();
            this.datetxt = new System.Windows.Forms.TextBox();
            this.Notxt = new System.Windows.Forms.TextBox();
            this.Lastnametxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Numbertxt = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblOUT = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtYearpaid
            // 
            this.txtYearpaid.Location = new System.Drawing.Point(113, 40);
            this.txtYearpaid.Name = "txtYearpaid";
            this.txtYearpaid.Size = new System.Drawing.Size(136, 20);
            this.txtYearpaid.TabIndex = 0;
            this.txtYearpaid.TextChanged += new System.EventHandler(this.txtYearpaid_TextChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblYear.Location = new System.Drawing.Point(19, 42);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(83, 18);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "ใส่รายได้ต่อปี";
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRun.FlatAppearance.BorderSize = 0;
            this.btnRun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(434, 385);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(137, 54);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "คำนวณภาษี";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // Childcheck
            // 
            this.Childcheck.AutoSize = true;
            this.Childcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Childcheck.Location = new System.Drawing.Point(130, 82);
            this.Childcheck.Name = "Childcheck";
            this.Childcheck.Size = new System.Drawing.Size(201, 17);
            this.Childcheck.TabIndex = 3;
            this.Childcheck.Text = "ลดหย่อนบุตร(พร้แมกรอกจำนวนบุตร)";
            this.Childcheck.UseVisualStyleBackColor = true;
            this.Childcheck.CheckedChanged += new System.EventHandler(this.Childcheck_CheckedChanged);
            // 
            // txtChildnum
            // 
            this.txtChildnum.Location = new System.Drawing.Point(130, 105);
            this.txtChildnum.Name = "txtChildnum";
            this.txtChildnum.Size = new System.Drawing.Size(128, 20);
            this.txtChildnum.TabIndex = 4;
            // 
            // checkSecurity
            // 
            this.checkSecurity.AutoSize = true;
            this.checkSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkSecurity.Location = new System.Drawing.Point(130, 141);
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
            this.porteclidecheck.Location = new System.Drawing.Point(130, 164);
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
            this.txtDeduction.Location = new System.Drawing.Point(19, 79);
            this.txtDeduction.Name = "txtDeduction";
            this.txtDeduction.Size = new System.Drawing.Size(105, 18);
            this.txtDeduction.TabIndex = 9;
            this.txtDeduction.Text = "เลือกการลดหย่อน";
            // 
            // SMPCheck
            // 
            this.SMPCheck.AutoSize = true;
            this.SMPCheck.Location = new System.Drawing.Point(130, 187);
            this.SMPCheck.Name = "SMPCheck";
            this.SMPCheck.Size = new System.Drawing.Size(183, 17);
            this.SMPCheck.TabIndex = 10;
            this.SMPCheck.Text = "ลดหย่อนส่วนตัว/คู่สมรส/คนพิการ";
            this.SMPCheck.UseVisualStyleBackColor = true;
            // 
            // GOCHcheck
            // 
            this.GOCHcheck.AutoSize = true;
            this.GOCHcheck.Location = new System.Drawing.Point(130, 211);
            this.GOCHcheck.Name = "GOCHcheck";
            this.GOCHcheck.Size = new System.Drawing.Size(85, 17);
            this.GOCHcheck.TabIndex = 11;
            this.GOCHcheck.Text = "กองทุน กอช.";
            this.GOCHcheck.UseVisualStyleBackColor = true;
            // 
            // rmfsffcheck
            // 
            this.rmfsffcheck.AutoSize = true;
            this.rmfsffcheck.Location = new System.Drawing.Point(130, 235);
            this.rmfsffcheck.Name = "rmfsffcheck";
            this.rmfsffcheck.Size = new System.Drawing.Size(112, 17);
            this.rmfsffcheck.TabIndex = 12;
            this.rmfsffcheck.Text = "กองทุนRMF / SFF";
            this.rmfsffcheck.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-4, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(694, 515);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnOBJ);
            this.tabPage1.Controls.Add(this.datetxt);
            this.tabPage1.Controls.Add(this.Notxt);
            this.tabPage1.Controls.Add(this.Lastnametxt);
            this.tabPage1.Controls.Add(this.Nametxt);
            this.tabPage1.Controls.Add(this.Numbertxt);
            this.tabPage1.Controls.Add(this.btnConfirm);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(686, 489);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnOBJ
            // 
            this.btnOBJ.Location = new System.Drawing.Point(161, 364);
            this.btnOBJ.Name = "btnOBJ";
            this.btnOBJ.Size = new System.Drawing.Size(130, 32);
            this.btnOBJ.TabIndex = 11;
            this.btnOBJ.Text = "ต้องการกรอกข้อมูล";
            this.btnOBJ.UseVisualStyleBackColor = true;
            this.btnOBJ.Click += new System.EventHandler(this.button2_Click);
            // 
            // datetxt
            // 
            this.datetxt.Location = new System.Drawing.Point(281, 295);
            this.datetxt.Name = "datetxt";
            this.datetxt.Size = new System.Drawing.Size(150, 20);
            this.datetxt.TabIndex = 10;
            // 
            // Notxt
            // 
            this.Notxt.Location = new System.Drawing.Point(281, 245);
            this.Notxt.Name = "Notxt";
            this.Notxt.Size = new System.Drawing.Size(150, 20);
            this.Notxt.TabIndex = 9;
            // 
            // Lastnametxt
            // 
            this.Lastnametxt.Location = new System.Drawing.Point(281, 193);
            this.Lastnametxt.Name = "Lastnametxt";
            this.Lastnametxt.Size = new System.Drawing.Size(150, 20);
            this.Lastnametxt.TabIndex = 8;
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(281, 135);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(150, 20);
            this.Nametxt.TabIndex = 7;
            // 
            // Numbertxt
            // 
            this.Numbertxt.Location = new System.Drawing.Point(281, 87);
            this.Numbertxt.Name = "Numbertxt";
            this.Numbertxt.Size = new System.Drawing.Size(150, 20);
            this.Numbertxt.TabIndex = 6;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(400, 364);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(135, 32);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "ยืนยันข้อมูล";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "วันเดือนปีเกิด";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "เบอร์โทร";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "นามสกุล";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "เลขบัตรประชาชน";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.Controls.Add(this.lblOUT);
            this.tabPage2.Controls.Add(this.checkSecurity);
            this.tabPage2.Controls.Add(this.btnRun);
            this.tabPage2.Controls.Add(this.Childcheck);
            this.tabPage2.Controls.Add(this.SMPCheck);
            this.tabPage2.Controls.Add(this.rmfsffcheck);
            this.tabPage2.Controls.Add(this.txtDeduction);
            this.tabPage2.Controls.Add(this.lblYear);
            this.tabPage2.Controls.Add(this.txtYearpaid);
            this.tabPage2.Controls.Add(this.txtChildnum);
            this.tabPage2.Controls.Add(this.porteclidecheck);
            this.tabPage2.Controls.Add(this.GOCHcheck);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(686, 489);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblOUT
            // 
            this.lblOUT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOUT.Location = new System.Drawing.Point(358, 45);
            this.lblOUT.Name = "lblOUT";
            this.lblOUT.Size = new System.Drawing.Size(292, 300);
            this.lblOUT.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 505);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Tax calculator for Thailand";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtYearpaid;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.CheckBox Childcheck;
        private System.Windows.Forms.TextBox txtChildnum;
        private System.Windows.Forms.CheckBox checkSecurity;
        private System.Windows.Forms.CheckBox porteclidecheck;
        private System.Windows.Forms.Label txtDeduction;
        private System.Windows.Forms.CheckBox SMPCheck;
        private System.Windows.Forms.CheckBox GOCHcheck;
        private System.Windows.Forms.CheckBox rmfsffcheck;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox datetxt;
        private System.Windows.Forms.TextBox Notxt;
        private System.Windows.Forms.TextBox Lastnametxt;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox Numbertxt;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOBJ;
        private System.Windows.Forms.Label lblOUT;
        private System.Windows.Forms.Button btnRun;
    }
}

