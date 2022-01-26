using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApplication
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Products();

              frm.MdiParent=this;
            frm.Show();
        }

        private void custmersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmCustomers();

            frm.MdiParent = this;
            frm.Show();
        }
    }
}
