using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardSlidingMenu
{
    public partial class frmFMDepartments : Form
    {
        public frmFMDepartments()
        {
            InitializeComponent();
        }

        private void frmFMDepartments_Load(object sender, EventArgs e)
        {
            this.bunifuCustomDataGrid1.RowHeadersVisible = false;

            string[] row = new string[] { "1", "Product 1", "1000" };
            bunifuCustomDataGrid1.Rows.Add(row);
            row = new string[] { "2", "Product 2", "2000" };
            bunifuCustomDataGrid1.Rows.Add(row);
            row = new string[] { "3", "Product 3", "3000" };
            bunifuCustomDataGrid1.Rows.Add(row);
            row = new string[] { "4", "Product 4", "4000" };
            bunifuCustomDataGrid1.Rows.Add(row);
        }
    }
}
