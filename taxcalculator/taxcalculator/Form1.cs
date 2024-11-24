﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        double yearpaid ; // รายได้รายปี
        double deduction =0; // ค่าลดหย่อน
        int Childnum; // จำนวนบุตร
        double money; //เงินสุทธิ
        double security;//ประกันสังคม
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

            Numbertxt.Enabled = false;
            Nametxt.Enabled = false;
            Lastnametxt.Enabled = false;
            Notxt.Enabled = false;
            datetxt.Enabled = false;
            btnConfirm.Enabled = false;
        }

        private void txtYearpaid_TextChanged(object sender, EventArgs e)
        {
            //ให้ใช้ตัวเลือกต่างๆได้หลังจากใส่จำนวนรายได้ต่อปีมาแล้ว
            txtDeduction.Enabled = true; 
            Childcheck.Enabled = true;
            checkSecurity.Enabled = true;
            porteclidecheck.Enabled = true;
            SMPCheck.Enabled=true;
            GOCHcheck.Enabled=true;
            rmfsffcheck.Enabled=true;

        }

        private void Childcheck_CheckedChanged(object sender, EventArgs e)
        {
            //ถ้าเลือกลดหย่อนบุตรให้เปิดตัวรับจำนวนบุตร
            txtChildnum.Enabled = true; 
           
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            try
            {
                // กำหนดค่าเริ่มต้นสำหรับค่าลดหย่อน
                deduction = 0;

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
                    // คำนวณเงินสุทธิ (รายได้ - ค่าลดหย่อน)
                    money = yearpaid - deduction;



                // แสดงผลลัพธ์  
                MessageBox.Show($"รายได้รายปี: {yearpaid:C}\r\n" +
                                $"ค่าลดหย่อนรวม: {deduction:C}\r\n" +
                                $"รายได้สุทธิที่ต้องเสียภาษี: {money:C}",
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

       //สร้าง method ไว้คำนวณภาษี
        public double Taxcalculated(double tax1) 
        {

            double taxtotal; // ภาษีที่ต้องจ่าย
            double tax; // ภาษี
            if (money < 150000) // ถ้าเงินสุทธิไม่ถึง150,000ไม่ต้องจ่ายภาษี
            {
                MessageBox.Show("ไม่ต้องจ่ายภาษี");
            }
            else if (money > 150001)
            {
                tax = 0.05;
                taxtotal = (money - 150000) * tax;
                MessageBox.Show("tax = 5%" + "\r\n" + "Total Tax: " + taxtotal.ToString());
            }
            else if (money > 300001)
            {
                tax = 0.10;
                taxtotal = ((money - 300000) * tax) + 7500;
                MessageBox.Show("tax = 10%" + "\r\n" + "Total Tax: " + taxtotal.ToString());
            }
            else if (money > 500001)
            {
                tax = 0.15;
                taxtotal = ((money - 500000) * tax) + 27500;
                MessageBox.Show("tax = 15%" + "\r\n" + "Total Tax: " + taxtotal.ToString());
            }
            else if (money > 750001)
            {
                tax = 0.20;
                taxtotal = ((money - 750000) * tax) + 65000;
                MessageBox.Show("tax = 20%" + "\r\n" + "Total Tax: " + taxtotal.ToString());
            }
            else if (money > 1000001)
            {
                tax = 0.25;
                taxtotal = ((money - 1000000) + tax) + 115000;
                MessageBox.Show("tax = 25%" + "\r\n" + "Total Tax: " + taxtotal.ToString());
            }
            else if (money > 2000001)
            {
                tax = 0.30;
                taxtotal = ((money - 2000000) * tax) + 365000;
                MessageBox.Show("tax = 30%" + "\r\n" + "Total Tax: " + taxtotal.ToString());
            }
            else if (money > 5000001)
            {
                tax = 0.35;
                taxtotal = ((money - 5000000) * tax) + 1265000;
                MessageBox.Show("tax = 35%" + "\r\n" + "Total Tax: " + taxtotal.ToString());
            }

            return tax1;
        }
        private void ShowProperty(info oc)
        {
            string StrOut = "";
            StrOut += "เลขบัตรประชาชน    " + oc.idnum + "\r\n";
            StrOut += "ชื่อ   " + oc.Name + "\r\n";
            StrOut += "นามสกุล   " + oc.Surname + "\r\n";
            StrOut += "เบอร์โทร  " + oc.Callnum.ToString()+ "\r\n";
            StrOut += "วัน/เดือน/ปีเกิด "  +oc.Birthdate + "\r\n";
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

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
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
        }
    }
}

