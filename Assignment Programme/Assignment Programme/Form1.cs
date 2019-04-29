using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Programme
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            frmcustomer f2 = new frmcustomer();
            f2.ShowDialog();
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            frmproduct f3 = new frmproduct();
            f3.ShowDialog();
        }
    }
}
