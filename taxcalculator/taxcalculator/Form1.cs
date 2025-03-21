﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taxcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        info objinfo;
        double yearpaid; // รายได้รายปี
        double deduction = 0; // ค่าลดหย่อน
        int Childnum; // จำนวนบุตร
        int parentnum; //จำนวนพ่อแม่
        double money; //เงินสุทธิ
        double security;//ประกันสังคม


        double Bussinessmoney;

        private void Form1_Load(object sender, EventArgs e)
        {
            //กำหนดให้ถ้ายังไม่ได้ใส่รายได้ต่อปีจะใช้การลดหย่อนไม่ได้
            txtDeduction.Enabled = false;
            Childcheck.Enabled = false;
            checkSecurity.Enabled = false;
            porteclidecheck.Enabled = false;
            txtChildnum.Enabled = false;
            SMPCheck.Enabled = false;
            GOCHcheck.Enabled = false;
            rmfsffcheck.Enabled = false;
            parentcheck.Enabled = false;
            techcheck.Enabled = false;
            chargcheck.Enabled = false;

            Numbertxt.Enabled = false;
            Nametxt.Enabled = false;
            Lastnametxt.Enabled = false;
            Notxt.Enabled = false;
            datetxt.Enabled = false;
            btnConfirm.Enabled = false;

            numlbl.Enabled = false;
            namlbl.Enabled = false;
            lastlbl.Enabled = false;
            nolbl.Enabled = false;
            datlbl.Enabled = false;
            lblYear.Enabled = false;
            txtYearpaid.Enabled = false;


            SMEcheck.Enabled = false;
            Checkbusiness.Enabled = false;

            pictureBox2.ImageLocation
                = Application.StartupPath + "\\RSURE.png ";
            
            picApple.ImageLocation =
                Application.StartupPath + "\\apple.png";
            
            picCoke.ImageLocation =
                Application.StartupPath + "\\coke.png";
            
            picMC.ImageLocation =
                Application.StartupPath + "\\mc.jpg";
            
            picTesla.ImageLocation =
                Application.StartupPath + "\\Tesla.png";
            
            picNV.ImageLocation =
                Application.StartupPath + "\\nv.jpg";
        }

        private void txtYearpaid_TextChanged(object sender, EventArgs e)
        {
            //ให้ใช้ตัวเลือกต่างๆได้หลังจากใส่จำนวนรายได้ต่อปีมาแล้ว
            txtDeduction.Enabled = true;
            Childcheck.Enabled = true;
            checkSecurity.Enabled = true;
            porteclidecheck.Enabled = true;
            SMPCheck.Enabled = true;
            GOCHcheck.Enabled = true;
            rmfsffcheck.Enabled = true;
            parentcheck.Enabled = true;
            techcheck.Enabled = true;
            chargcheck.Enabled = true;

        }

        private void Childcheck_CheckedChanged(object sender, EventArgs e)
        {
            //ถ้าเลือกลดหย่อนบุตรให้เปิดตัวรับจำนวนบุตร
            txtChildnum.Enabled = true;

        }

        //สร้าง method ไว้คำนวณภาษี
        public double Taxcalculated()
        {

            double taxtotal = 0; // ภาษีที่ต้องจ่าย
            
            double tax = 0; // ภาษี

            if (money < 150000) // ถ้าเงินสุทธิไม่ถึง150,000ไม่ต้องจ่ายภาษี
            {
                
                MessageBox.Show("ไม่ต้องจ่ายภาษี");
            
            }
            else if (money > 150001)
            {
                tax = 0.05;
                
                taxtotal = (money - 150000) * tax;
                
                MessageBox.Show("tax = 5%" + "\r\n" + "Total Tax: "
                    + taxtotal.ToString("C"));
            }
            else if (money > 300001)
            {
                tax = 0.10;
                
                taxtotal = ((money - 300000) * tax) + 7500;
                
                MessageBox.Show("tax = 10%" + "\r\n" + "Total Tax: "
                    + "" + taxtotal.ToString("C"));
            }
            else if (money > 500001)
            {
                tax = 0.15;
               
                taxtotal = ((money - 500000) * tax) + 27500;
                
                MessageBox.Show("tax = 15%" + "\r\n" + "Total Tax: "
                    + taxtotal.ToString("C"));
            }
            else if (money > 750001)
            {
                tax = 0.20;
                
                taxtotal = ((money - 750000) * tax) + 65000;
                
                MessageBox.Show("tax = 20%" + "\r\n" + "Total Tax: "
                    + taxtotal.ToString("C"));
            }
            else if (money > 1000001)
            {
                tax = 0.25;
                
                taxtotal = ((money - 1000000) + tax) + 115000;
                
                MessageBox.Show("tax = 25%" + "\r\n" + "Total Tax: "
                    + taxtotal.ToString("C"));
            }
            else if (money > 2000001)
            {
                tax = 0.30;
                
                taxtotal = ((money - 2000000) * tax) + 365000;
                
                MessageBox.Show("tax = 30%" + "\r\n" + "Total Tax: "
                    + taxtotal.ToString("C"));
            }
            else if (money > 5000001)
            {
                tax = 0.35;
               
                taxtotal = ((money - 5000000) * tax) + 1265000;
                
                MessageBox.Show("tax = 35%" + "\r\n" + "Total Tax: "
                    + taxtotal.ToString("C"));
            }

            return taxtotal;
        }
        private void btnRun_Click(object sender, EventArgs e)
        {

            try
            {
                // กำหนดค่าเริ่มต้นสำหรับค่าลดหย่อน
                deduction = 0;
                double persent = 0;

                // ตรวจสอบว่าผู้ใช้กรอกข้อมูลรายได้รายปีหรือยัง
                if (string.IsNullOrEmpty(txtYearpaid.Text) || !double.TryParse(txtYearpaid.Text, out yearpaid))
                {

                    MessageBox.Show("กรุณากรอกข้อมูลรายได้รายปีให้ถูกต้อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }


                // คำนวณค่าลดหย่อนจากจำนวนบุตร
                if (Childcheck.Checked && int.TryParse(txtChildnum.Text, out Childnum))
                {

                    // ค่าลดหย่อนจากบุตรจำนวน * 30000
                    deduction += Childnum * 30000;

                }

                // คำนวณค่าลดหย่อนจากประกันสังคม
                if (checkSecurity.Checked)
                {
                    deduction += 5850;
                }

                // คำนวณค่าลดหย่อนบำนาญ (Pension)
                if (porteclidecheck.Checked)
                {
                    double pensionDeduction = (yearpaid * 15) / 100;
                    //หากเกิน200000 ให้ลดหย่อน=200000
                    deduction += (pensionDeduction > 200000)
                        ? 200000 : pensionDeduction;
                }

                // คำนวณค่าลดหย่อนส่วนตัว/สมรส/พิการ
                if (SMPCheck.Checked)
                {
                    deduction += 60000;
                }

                // คำนวณค่าลดหย่อนจากกองทุนกอช
                if (GOCHcheck.Checked)
                {
                    deduction += 13200;
                }

                //คำนวญส่วนลดเมื่อrmfsffถูกcheck
                if (rmfsffcheck.Checked)
                {
                    //คำนวยจากรายได้*30%ของเงิน
                    double pensionDeduction = (yearpaid * 30) / 100;
                    //หากเกิน500000 ให้ลดหย่อน=500000
                    deduction += (pensionDeduction > 500000)
                        ? 500000 : pensionDeduction;

                }

                //คำนวญเมื่อพ่อเเม่เช็ค
                if (parentcheck.Checked && int.TryParse(parenttxt.Text, out parentnum))
                {

                    // ค่าลดหย่อนจากพ่อแม่จำนวน * 30000
                    deduction += parentnum * 30000;

                }
                //คำนวญเมื่อสะสมดดนเช็ค
                if (chargcheck.Checked)
                {
                    // ค่าลดหย่อนได้100000
                    deduction += 100000;

                }

                //คำนวญเมื่อครโดนเช็ค
                if (techcheck.Checked)
                {

                    //คำนวยจากรายได้*15%ของเงิน
                    double pensionDeduction = (yearpaid * 15) / 100;
                    //หากเกิน200000 ให้ลดหย่อน=200000
                    deduction += (pensionDeduction > 200000)
                        ? 200000 : pensionDeduction;
                }
                {

                }
                // คำนวณเงินสุทธิ (รายได้ - ค่าลดหย่อน)
                money = yearpaid - deduction;

                // persent = taxtotal / money;


                double taxtotal = Taxcalculated();

                // แสดงผลลัพธ์  
                MessageBox.Show($"รายได้รายปี: {yearpaid:C}\r\n" +
                        $"ค่าลดหย่อนรวม: {deduction:C}\r\n" +
                        $"เงินสุทธิ: {money:C}\r\n" +
                        $"ภาษีที่ต้องชำระ: {taxtotal:C}\r\n"
                        // $"ภาษีคิดเป็น:{:C}"
                        ,
                        "ผลการคำนวณ", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


            }

            //หากไม่มีการป้อนก็จะให้เเสดงผลตามคำสั่ง
            catch (Exception ex)
            {

                MessageBox.Show($"เกิดข้อผิดพลาด: {ex.Message}", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }



        private void ShowProperty(info oc)
        {
            //กำหนดสตริงเพื่อเเสดงข้อมูลที่รับมา
            string StrOut = "";
            StrOut += "เลขบัตรประชาชน        " + oc.idnum + "\r\n";
            StrOut += "ชื่อ       " + oc.Name + "\r\n";
            StrOut += "นามสกุล       " + oc.Surname + "\r\n";
            StrOut += "เบอร์โทร      " + oc.Callnum.ToString() + "\r\n";
            StrOut += "วัน/เดือน/ปีเกิด     " + oc.Birthdate + "\r\n";

            lblOUT.Text = StrOut;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            objinfo = new info();
            ShowProperty(objinfo);
            btnOBJ.Enabled = false;
            Numbertxt.Enabled = true;
            Nametxt.Enabled = true;
            Lastnametxt.Enabled = true;
            Notxt.Enabled = true;
            datetxt.Enabled = true;
            btnConfirm.Enabled = true;
            numlbl.Enabled = true;
            namlbl.Enabled = true;
            lastlbl.Enabled = true;
            nolbl.Enabled = true;
            datlbl.Enabled = true;

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            lblYear.Enabled = true;
            txtYearpaid.Enabled = true;
            //ดุเงื่อนไขหากไม่มีการใส่ข้อมูลให้ดชว์ข้อควา่ม
            if (objinfo == null)
            {
                MessageBox.Show("Object is not initialized. Please click the initialize button first.");
                return;
            }
            objinfo.idnum = Numbertxt.Text;
            objinfo.Name = Nametxt.Text;
            objinfo.Surname = Lastnametxt.Text;
            objinfo.Callnum = Notxt.Text;
            objinfo.Birthdate = datetxt.Text;
            ShowProperty(objinfo);

            MessageBox.Show("ยืนยันข้อมูลเสร็จสิ้น");

            picRSU.ImageLocation
                = Application.StartupPath + "\\rangsit.png ";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtINCOME_TextChanged(object sender, EventArgs e)
        {
            SMEcheck.Enabled = true;
            Checkbusiness.Enabled = true;
        }


       

        private void btnNITI_Click(object sender, EventArgs e)
        {
            double nitimoney = Convert.ToDouble(txtINCOME.Text); //รายได้
            double nitiOUTCOME = Convert.ToDouble(txtOUTCOME.Text); //รายจ่าย
            double profit = nitimoney - nitiOUTCOME;

            double taxSME = 0; //ภาษีของ SME
            double taxsmeruam = 0; //ภาษีสรุปของ SME

            double taxbussiness = 0;
            double taxnormalruam = 0;

            //ให้เงื่อนไขเมื่อSMEเช็ค
            if (SMEcheck.Checked)
            {
                if (profit < 300000)
                {
                    MessageBox.Show("ได้รับการยกเว้นภาษี");
                }
                else if (profit <= 3000000)
                {
                    taxSME = 0.15;
                    taxsmeruam = profit * taxSME;
                    MessageBox.Show("tax = 15%" + "\r\n" + "Total Tax: " //ภาษี*15%
                        + taxsmeruam.ToString("C"));
                }
                else
                {
                    taxSME = 0.20;
                    taxsmeruam = profit * taxSME;
                    MessageBox.Show("tax = 20%" + "\r\n" + "Total Tax: "//ภาษี*15%
                        + taxsmeruam.ToString("C"));
                }
            }
            else if (Checkbusiness.Checked)
            {
               
                if (profit >= 1)
                {
                   taxbussiness = 0.20;
                   taxnormalruam = profit * taxbussiness;
                   MessageBox.Show("tax = 20%" + "\r\n" + "Total Tax: "
                    + taxnormalruam.ToString("C"));
                }
                else
                {
                    MessageBox.Show("ได้รับการยกเว้นภาษี");
                }
           
            }
        }

        //สร้างvoid เพื่อใช้ปุ่มทำงาน
        private void button1_Click(object sender, EventArgs e)
        {
            double principle = Convert.ToDouble(txtprinciple.Text); //สร้างตัวเเเปรรับค่าจากtextbox
            double stock; //สร้างตัวเเปร storkเก็บค่าราคาหุ้น
            double ruam1;
            double ruam2;
            
            //เงื่อนไขเมื่อcheckNV
            if (checkNV.Checked)
            {
                if (check1yearNV.Checked)
                {
                    stock = 193.69;
                    ruam1 = (principle * stock)/100;
                    ruam2 = ruam1 + principle;
                    MessageBox.Show(ruam2.ToString());
                }
                else if (check3yearNV.Checked)
                {
                    stock = 345.40;
                    ruam1 = (principle * stock) /100;
                    ruam2 = ruam1 + principle;
                    MessageBox.Show(ruam2.ToString());
                }
                else if (check5yearNV.Checked)
                {
                    stock = 2704.40;
                    ruam1 = (principle * stock) /100;
                    ruam2 = ruam1 + principle;
                    MessageBox.Show(ruam2.ToString());
                }
                else if (check10yearNV.Checked)
                {
                    stock = 29832.65;
                    ruam1 = (principle * stock)/100;
                    ruam2 = ruam1 + principle;
                    MessageBox.Show(ruam2.ToString());
                }
                else MessageBox.Show("กรุณาเรียกทีละปี");
            }

            //เงื่อนไขเมื่อcheckTESLA
            else if (checkTESLA.Checked)
            {
                if (check1yearTesla.Checked)
                {
                    stock = 40.81;
                    ruam1 = (principle * stock)/100;
                    ruam2 = ruam1 + principle;
                    MessageBox.Show(ruam2.ToString());
                }
                else if (check3yearTesla.Checked)
                {
                    stock = 10.39 ;
                    ruam1 = (principle * stock)/100;
                    ruam2 = ruam1 + principle;
                    MessageBox.Show(ruam2.ToString());
                }
                else if (check5yearTesla.Checked)
                {
                    stock = 1335.50;
                    ruam1 = (principle * stock)/100;
                    ruam2 = ruam1 + principle;
                    MessageBox.Show(ruam2.ToString());
                }
                else if (check10yearTesla.Checked)
                {
                    stock = 1997.84;
                    ruam1 = (principle * stock)/100;
                    ruam2 = ruam1 + principle;
                    MessageBox.Show(ruam2.ToString());
                }
                else MessageBox.Show("กรุณาเรียกทีละปี");
               
            }

            //เงื่อนไขเมื่อcheckMicrosoft
            else if (checkMicrosoft.Checked)
            {
                if (check1MC.Checked)
                {
                    stock = 10.67;
                    ruam1 = (principle * stock)/ 100;
                    ruam2 = ruam1 + principle;
                    MessageBox.Show(ruam2.ToString());
                }
                else if (check3MC.Checked)
                {
                    stock = 21.76;
                    ruam1 = (principle * stock) / 100;
                    ruam2 = ruam1 + principle;
                    MessageBox.Show(ruam2.ToString());
                }
                else if (check5MC.Checked)
                {
                    stock = 184.82;
                    ruam1 = (principle * stock) / 100;
                    ruam2 = ruam1 + principle;
                    MessageBox.Show(ruam2.ToString());
                }
                else if (check10MC.Checked)
                {
                    stock = 888.44;
                    ruam1 = (principle * stock) / 100;
                    ruam2 = ruam1 + principle;
                    MessageBox.Show(ruam2.ToString());
                }
                else MessageBox.Show("กรุณาเรียกทีละปี");
            }

            //เงื่อนไขเมื่อcheckApple
            else if (checkApple.Checked)
            {
                if (check1Apple.Checked)
                {
                    stock = 19.83;
                    ruam1 = (principle * stock) / 100;
                    ruam2 = ruam1 + principle;
                    MessageBox.Show(ruam2.ToString());
                }
                else if (check3Apple.Checked)
                {
                    stock = 43.34;
                    ruam1 = (principle * stock) / 100;
                    ruam2 = ruam1 + principle;
                    MessageBox.Show(ruam2.ToString());
                }
                else if (check5Apple.Checked)
                {
                    stock = 256.56;
                    ruam1 = (principle * stock) / 100;
                    ruam2 = ruam1 + principle;
                    MessageBox.Show(ruam2.ToString());
                }
                else if (check10Apple.Checked)
                {
                    stock = 772.95;
                    ruam1 = (principle * stock) / 100;
                    ruam2 = ruam1 + principle;
                    MessageBox.Show(ruam2.ToString());
                }
                else MessageBox.Show("กรุณาเรียกทีละปี");
            }

            //เงื่อนไขเมื่อcheckCOLA
            else if (checkCocaCola.Checked)
            {
                if (check1Coke.Checked)
                {
                    stock = 9.58;
                    ruam1 = (principle * stock) / 100;
                    ruam2 = ruam1 + principle;
                    MessageBox.Show(ruam2.ToString());
                }
                else if (check3Coke.Checked)
                {
                   stock = 20.60;
                   ruam1 = (principle * stock) / 100;
                   ruam2 = ruam1 + principle;
                    MessageBox.Show(ruam2.ToString());
                }
                else if (check5Coke.Checked)
                {
                    stock = 33.90;
                    ruam1 = (principle * stock) / 100;
                    ruam2 = ruam1 + principle;
                    MessageBox.Show(ruam2.ToString());
                }
                else if (check10Coke.Checked)
                {
                    stock = 87.47;
                    ruam1 = (principle * stock) / 100;
                    ruam2 = ruam1 + principle;
                    MessageBox.Show(ruam2.ToString());
                }
                else MessageBox.Show("กรุณาเรียกทีละปี");
            }
            else MessageBox.Show("กรุณาเรียกทีละบริษัท");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

