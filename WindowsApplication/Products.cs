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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Service_Products.ProducsServiceClient _clientData = new Service_Products.ProducsServiceClient();
            dgProducts.DataSource = _clientData.GetAllProducts();
        }
    }
}
