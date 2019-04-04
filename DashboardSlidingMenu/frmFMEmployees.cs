using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;

namespace DashboardSlidingMenu
{
    public partial class frmFMEmployees : Form
    {
        bool click = false;
        public frmFMEmployees()
        {
            InitializeComponent();
        }

        private void frmFMEmployees_Load(object sender, EventArgs e)
        {
            lollipopCard1.Text = "Employee ID: EMP-2018-0924";
            lollipopCard1.ContentText = "Fullname: "+"Emelson Luntiang Parol";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}
