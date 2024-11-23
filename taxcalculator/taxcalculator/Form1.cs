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
        double deduction; // ค่าลดหย่อน
        int Childnum; // จำนวนบุตร
        double money; //เงินสุทธิ
        double security;//ประกันสังคม
        private void Form1_Load(object sender, EventArgs e)
        {
            txtDeduction.Enabled = false; //กำหนดให้ถ้ายังไม่ได้ใส่รายได้ต่อปีจะใช้การลดหย่อนไม่ได้
            Childcheck.Enabled = false;
            checkSecurity.Enabled = false;
            checkPension.Enabled = false;
            txtChildnum.Enabled = false;
            lblChild.Enabled = false;

        }

        private void txtYearpaid_TextChanged(object sender, EventArgs e)
        {
            txtDeduction.Enabled = true; //ให้ใช้ตัวเลือกต่างๆได้หลังจากใส่จำนวนรายได้ต่อปีมาแล้ว
            Childcheck.Enabled = true;
            checkSecurity.Enabled = true;
            checkPension.Enabled = true;

        }

        private void Childcheck_CheckedChanged(object sender, EventArgs e)
        {
            txtChildnum.Enabled = true; //ถ้าเลือกลดหย่อนบุตรให้เปิดตัวรับจำนวนบุตร
            lblChild.Enabled = true;
        }

        private void btnRun_Click(object sender, EventArgs e)
        { 
            Childnum = Convert.ToInt32(txtChildnum.Text); 
            yearpaid = Convert.ToDouble(txtYearpaid.Text);
            if (Childcheck.Checked) 
            {
                deduction = Childnum * 30000; //ค่าลดหย่อน = จำนวนบุตร * 30000
            }
            else if (checkSecurity.Checked)
            {
                deduction = 5850;
            }
            else if (checkPension.Checked)
            {
                deduction = (yearpaid * 15) / 100; //ค่าลดหย่อน = รายได้ต่อปี * 15%
                if (deduction > 200000)
                {       
                    deduction = 200000; //ถ้าค่าลดหย่อนเกิน 200000 ให้ค่าลดหย่อน = 2000000 
                }
               
            }
            money = yearpaid - deduction;   
            MessageBox.Show(money.ToString()); //-----------อาจจะทำผิดอย่าพึ่งทำอย่างกู----------------//
           
            
        }
    }
}
