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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnOBJ = new System.Windows.Forms.Button();
            this.datetxt = new System.Windows.Forms.TextBox();
            this.Notxt = new System.Windows.Forms.TextBox();
            this.Lastnametxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Numbertxt = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.datlbl = new System.Windows.Forms.Label();
            this.nolbl = new System.Windows.Forms.Label();
            this.lastlbl = new System.Windows.Forms.Label();
            this.namlbl = new System.Windows.Forms.Label();
            this.numlbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.parenttxt = new System.Windows.Forms.TextBox();
            this.techcheck = new System.Windows.Forms.CheckBox();
            this.chargcheck = new System.Windows.Forms.CheckBox();
            this.parentcheck = new System.Windows.Forms.CheckBox();
            this.lblOUT = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYearpaid
            // 
            this.txtYearpaid.Location = new System.Drawing.Point(126, 39);
            this.txtYearpaid.Name = "txtYearpaid";
            this.txtYearpaid.Size = new System.Drawing.Size(136, 23);
            this.txtYearpaid.TabIndex = 0;
            this.txtYearpaid.TextChanged += new System.EventHandler(this.txtYearpaid_TextChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblYear.Location = new System.Drawing.Point(22, 42);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(80, 16);
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
            this.btnRun.Location = new System.Drawing.Point(443, 370);
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
            this.Childcheck.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Childcheck.Location = new System.Drawing.Point(126, 68);
            this.Childcheck.Name = "Childcheck";
            this.Childcheck.Size = new System.Drawing.Size(224, 20);
            this.Childcheck.TabIndex = 3;
            this.Childcheck.Text = "ลดหย่อนบุตร(พร้อมกรอกจำนวนบุตร)";
            this.Childcheck.UseVisualStyleBackColor = true;
            this.Childcheck.CheckedChanged += new System.EventHandler(this.Childcheck_CheckedChanged);
            // 
            // txtChildnum
            // 
            this.txtChildnum.Location = new System.Drawing.Point(126, 94);
            this.txtChildnum.Name = "txtChildnum";
            this.txtChildnum.Size = new System.Drawing.Size(93, 23);
            this.txtChildnum.TabIndex = 4;
            // 
            // checkSecurity
            // 
            this.checkSecurity.AutoSize = true;
            this.checkSecurity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkSecurity.Location = new System.Drawing.Point(126, 204);
            this.checkSecurity.Name = "checkSecurity";
            this.checkSecurity.Size = new System.Drawing.Size(140, 20);
            this.checkSecurity.TabIndex = 6;
            this.checkSecurity.Text = "ลดหย่อนประกันสังคม";
            this.checkSecurity.UseVisualStyleBackColor = true;
            // 
            // porteclidecheck
            // 
            this.porteclidecheck.AutoSize = true;
            this.porteclidecheck.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.porteclidecheck.Location = new System.Drawing.Point(126, 256);
            this.porteclidecheck.Name = "porteclidecheck";
            this.porteclidecheck.Size = new System.Drawing.Size(101, 20);
            this.porteclidecheck.TabIndex = 7;
            this.porteclidecheck.Text = "ประกันบำนาญ";
            this.porteclidecheck.UseVisualStyleBackColor = true;
            // 
            // txtDeduction
            // 
            this.txtDeduction.AutoSize = true;
            this.txtDeduction.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtDeduction.Location = new System.Drawing.Point(12, 72);
            this.txtDeduction.Name = "txtDeduction";
            this.txtDeduction.Size = new System.Drawing.Size(103, 16);
            this.txtDeduction.TabIndex = 9;
            this.txtDeduction.Text = "เลือกการลดหย่อน";
            // 
            // SMPCheck
            // 
            this.SMPCheck.AutoSize = true;
            this.SMPCheck.Location = new System.Drawing.Point(126, 123);
            this.SMPCheck.Name = "SMPCheck";
            this.SMPCheck.Size = new System.Drawing.Size(203, 20);
            this.SMPCheck.TabIndex = 10;
            this.SMPCheck.Text = "ลดหย่อนส่วนตัว/คู่สมรส/คนพิการ";
            this.SMPCheck.UseVisualStyleBackColor = true;
            // 
            // GOCHcheck
            // 
            this.GOCHcheck.AutoSize = true;
            this.GOCHcheck.Location = new System.Drawing.Point(126, 282);
            this.GOCHcheck.Name = "GOCHcheck";
            this.GOCHcheck.Size = new System.Drawing.Size(97, 20);
            this.GOCHcheck.TabIndex = 11;
            this.GOCHcheck.Text = "กองทุน กอช.";
            this.GOCHcheck.UseVisualStyleBackColor = true;
            // 
            // rmfsffcheck
            // 
            this.rmfsffcheck.AutoSize = true;
            this.rmfsffcheck.Location = new System.Drawing.Point(126, 308);
            this.rmfsffcheck.Name = "rmfsffcheck";
            this.rmfsffcheck.Size = new System.Drawing.Size(125, 20);
            this.rmfsffcheck.TabIndex = 12;
            this.rmfsffcheck.Text = "กองทุนRMF / SFF";
            this.rmfsffcheck.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tabControl1.Location = new System.Drawing.Point(-4, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(694, 515);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.btnOBJ);
            this.tabPage1.Controls.Add(this.datetxt);
            this.tabPage1.Controls.Add(this.Notxt);
            this.tabPage1.Controls.Add(this.Lastnametxt);
            this.tabPage1.Controls.Add(this.Nametxt);
            this.tabPage1.Controls.Add(this.Numbertxt);
            this.tabPage1.Controls.Add(this.btnConfirm);
            this.tabPage1.Controls.Add(this.datlbl);
            this.tabPage1.Controls.Add(this.nolbl);
            this.tabPage1.Controls.Add(this.lastlbl);
            this.tabPage1.Controls.Add(this.namlbl);
            this.tabPage1.Controls.Add(this.numlbl);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(686, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ข้อมูล";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(271, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // btnOBJ
            // 
            this.btnOBJ.Location = new System.Drawing.Point(171, 400);
            this.btnOBJ.Name = "btnOBJ";
            this.btnOBJ.Size = new System.Drawing.Size(130, 32);
            this.btnOBJ.TabIndex = 11;
            this.btnOBJ.Text = "ต้องการกรอกข้อมูล";
            this.btnOBJ.UseVisualStyleBackColor = true;
            this.btnOBJ.Click += new System.EventHandler(this.button2_Click);
            // 
            // datetxt
            // 
            this.datetxt.Location = new System.Drawing.Point(295, 358);
            this.datetxt.Name = "datetxt";
            this.datetxt.Size = new System.Drawing.Size(150, 23);
            this.datetxt.TabIndex = 10;
            this.datetxt.Text = "00/00/00";
            // 
            // Notxt
            // 
            this.Notxt.Location = new System.Drawing.Point(295, 308);
            this.Notxt.Name = "Notxt";
            this.Notxt.Size = new System.Drawing.Size(150, 23);
            this.Notxt.TabIndex = 9;
            // 
            // Lastnametxt
            // 
            this.Lastnametxt.Location = new System.Drawing.Point(295, 256);
            this.Lastnametxt.Name = "Lastnametxt";
            this.Lastnametxt.Size = new System.Drawing.Size(150, 23);
            this.Lastnametxt.TabIndex = 8;
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(295, 198);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(150, 23);
            this.Nametxt.TabIndex = 7;
            // 
            // Numbertxt
            // 
            this.Numbertxt.Location = new System.Drawing.Point(295, 146);
            this.Numbertxt.Name = "Numbertxt";
            this.Numbertxt.Size = new System.Drawing.Size(150, 23);
            this.Numbertxt.TabIndex = 6;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(371, 400);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(135, 32);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "ยืนยันข้อมูล";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // datlbl
            // 
            this.datlbl.AutoSize = true;
            this.datlbl.Location = new System.Drawing.Point(188, 358);
            this.datlbl.Name = "datlbl";
            this.datlbl.Size = new System.Drawing.Size(77, 16);
            this.datlbl.TabIndex = 4;
            this.datlbl.Text = "วันเดือนปีเกิด";
            // 
            // nolbl
            // 
            this.nolbl.AutoSize = true;
            this.nolbl.Location = new System.Drawing.Point(205, 311);
            this.nolbl.Name = "nolbl";
            this.nolbl.Size = new System.Drawing.Size(54, 16);
            this.nolbl.TabIndex = 3;
            this.nolbl.Text = "เบอร์โทร";
            // 
            // lastlbl
            // 
            this.lastlbl.AutoSize = true;
            this.lastlbl.Location = new System.Drawing.Point(205, 256);
            this.lastlbl.Name = "lastlbl";
            this.lastlbl.Size = new System.Drawing.Size(53, 16);
            this.lastlbl.TabIndex = 2;
            this.lastlbl.Text = "นามสกุล";
            // 
            // namlbl
            // 
            this.namlbl.AutoSize = true;
            this.namlbl.Location = new System.Drawing.Point(217, 201);
            this.namlbl.Name = "namlbl";
            this.namlbl.Size = new System.Drawing.Size(23, 16);
            this.namlbl.TabIndex = 1;
            this.namlbl.Text = "ชื่อ";
            // 
            // numlbl
            // 
            this.numlbl.AutoSize = true;
            this.numlbl.Location = new System.Drawing.Point(188, 153);
            this.numlbl.Name = "numlbl";
            this.numlbl.Size = new System.Drawing.Size(99, 16);
            this.numlbl.TabIndex = 0;
            this.numlbl.Text = "เลขบัตรประชาชน";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.parenttxt);
            this.tabPage2.Controls.Add(this.techcheck);
            this.tabPage2.Controls.Add(this.chargcheck);
            this.tabPage2.Controls.Add(this.parentcheck);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(686, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "คำนวณภาษี";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox1.Location = new System.Drawing.Point(563, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // parenttxt
            // 
            this.parenttxt.Location = new System.Drawing.Point(126, 175);
            this.parenttxt.Name = "parenttxt";
            this.parenttxt.Size = new System.Drawing.Size(93, 23);
            this.parenttxt.TabIndex = 17;
            // 
            // techcheck
            // 
            this.techcheck.AutoSize = true;
            this.techcheck.Location = new System.Drawing.Point(126, 334);
            this.techcheck.Name = "techcheck";
            this.techcheck.Size = new System.Drawing.Size(120, 20);
            this.techcheck.TabIndex = 16;
            this.techcheck.Text = "กบข.สงเคราะห์ครู";
            this.techcheck.UseVisualStyleBackColor = true;
            // 
            // chargcheck
            // 
            this.chargcheck.AutoSize = true;
            this.chargcheck.Location = new System.Drawing.Point(126, 230);
            this.chargcheck.Name = "chargcheck";
            this.chargcheck.Size = new System.Drawing.Size(114, 20);
            this.chargcheck.TabIndex = 15;
            this.chargcheck.Text = "ประกันชีวิตสะสม";
            this.chargcheck.UseVisualStyleBackColor = true;
            // 
            // parentcheck
            // 
            this.parentcheck.AutoSize = true;
            this.parentcheck.Location = new System.Drawing.Point(126, 149);
            this.parentcheck.Name = "parentcheck";
            this.parentcheck.Size = new System.Drawing.Size(93, 20);
            this.parentcheck.TabIndex = 14;
            this.parentcheck.Text = "เลี้ยงดูพ่อแม่";
            this.parentcheck.UseVisualStyleBackColor = true;
            // 
            // lblOUT
            // 
            this.lblOUT.BackColor = System.Drawing.Color.MintCream;
            this.lblOUT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOUT.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOUT.Location = new System.Drawing.Point(358, 45);
            this.lblOUT.Name = "lblOUT";
            this.lblOUT.Size = new System.Drawing.Size(314, 305);
            this.lblOUT.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 505);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Tax calculator for Thailand";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label datlbl;
        private System.Windows.Forms.Label nolbl;
        private System.Windows.Forms.Label lastlbl;
        private System.Windows.Forms.Label namlbl;
        private System.Windows.Forms.Label numlbl;
        private System.Windows.Forms.Button btnOBJ;
        private System.Windows.Forms.Label lblOUT;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.CheckBox techcheck;
        private System.Windows.Forms.CheckBox chargcheck;
        private System.Windows.Forms.CheckBox parentcheck;
        private System.Windows.Forms.TextBox parenttxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

