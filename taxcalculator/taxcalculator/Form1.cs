using System;
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
            lblChild.Enabled = false;
            SMPCheck.Enabled = false;
            GOCHcheck.Enabled = false;
            rmfsffcheck.Enabled = false;
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
            lblChild.Enabled = true;
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
    }
}


