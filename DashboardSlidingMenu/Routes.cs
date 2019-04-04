using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardSlidingMenu
{
    class Routes
    {
        public void Access(string location, ref frmBase frmBase)
        {
            switch (location.ToLower())
            {
                case "    general":
                    frmFMEmployees frmFMEmployees = new frmFMEmployees();
                    frmFMEmployees.MdiParent = frmBase;
                    frmFMEmployees.Show();
                    break;
                case "    system analyst":
                    frmFMDepartments frmFMDepartments = new frmFMDepartments();
                    frmFMDepartments.MdiParent = frmBase;
                    frmFMDepartments.Show();
                    break;
                default:
                    MessageBox.Show("Please try again. Page cannot be opened.");
                    break;
            }
        }
    }
}
