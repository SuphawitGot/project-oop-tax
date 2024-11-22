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
        private void Form1_Load(object sender, EventArgs e)
        {
            txtDeduction.Enabled = false; //กำหนดให้ถ้ายังไม่ได้ใส่เงินรายปีจะใช้การลดหย่อนไม่ได้
            Childcheck.Enabled = false;
            checkSecurity.Enabled = false;
            checkPension.Enabled = false;
            txtChildnum.Enabled = false;
            lblChild.Enabled = false;

        }

        private void txtYearpaid_TextChanged(object sender, EventArgs e)
        {
            txtDeduction.Enabled = true; //ให้ใช้ตัวเลือกต่างๆได้หลังจากใส่จำนวนรายได้รายปีมาแล้ว
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
            
            
           
            
        }
    }
}
