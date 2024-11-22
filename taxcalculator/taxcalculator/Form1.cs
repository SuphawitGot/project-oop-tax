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
        int yearpaid ;
        private void Form1_Load(object sender, EventArgs e)
        {
            txtDeduction.Enabled = false;
            Childcheck.Enabled = false;
            checkSecurity.Enabled = false;
            checkPension.Enabled = false;
            txtChildnum.Enabled = false;
            lblChild.Enabled = false;
            
            

        }

        private void txtYearpaid_TextChanged(object sender, EventArgs e)
        {
            txtDeduction.Enabled = true;
            Childcheck.Enabled = true;
            checkSecurity.Enabled = true;
            checkPension.Enabled = true;

        }

        private void Childcheck_CheckedChanged(object sender, EventArgs e)
        {
            txtChildnum.Enabled = true;
            lblChild.Enabled = true;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
           
        }
    }
}
