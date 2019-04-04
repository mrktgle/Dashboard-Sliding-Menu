using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardSlidingMenu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }

        public static bool IsDesignMode()
        {
            if(Application.ExecutablePath.IndexOf("devenv.exe",StringComparison.OrdinalIgnoreCase ) >-1)
            {
                return true;
            }
            return false;
        }
    }
}
