using CourseManageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseMgtPage1
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

            //show login window first:
            FrmCover frmlogin = new FrmCover();
            DialogResult result = frmlogin.ShowDialog();

            //by return value of showdialog result, main window can be hiden or shown
            if (result == DialogResult.OK)
            {
                Application.Run(new frmMain());
            }
            else
            {
                Application.Exit();
            }           
        }

        public static Teacher currentTeacher = null;
    }
}
