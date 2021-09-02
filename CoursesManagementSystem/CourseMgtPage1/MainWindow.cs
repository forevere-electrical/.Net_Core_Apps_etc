using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseMgtPage1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            
            InitializeComponent();
            this.lblLoginClient.Text = Program.currentTeacher.TeacherName;
        }

        #region Window Move by left mouse button draging

        private Point mouseOff; //position of mouse moving
        private bool leftFlag; //a flag if leftbutton clicked
        private void Frm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); // get the value of current position
                leftFlag = true; // when left button clicked, set flag to true
            }
        }

        private void Frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y); //set position after moving
                Location = mouseSet;
            }
        }
        private void Frm_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag) leftFlag = false;
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            closePreviousSelect();

            FrmAddCourse newCource = new FrmAddCourse();
            newCource.TopLevel = false;
            newCource.FormBorderStyle = FormBorderStyle.None;
            newCource.Dock = DockStyle.Fill;
            newCource.Parent = this.pnlRight;
            newCource.Show();
        }

        private void btnCourseManagement_Click(object sender, EventArgs e)
        {
            closePreviousSelect();
            FrmCourseMgt childForm = new FrmCourseMgt();
            childForm.TopLevel = false; //set child window to false top level for embedding to parent window

            childForm.FormBorderStyle = FormBorderStyle.None;// if the embedded form has a border, remove the border.
            childForm.Dock = DockStyle.Fill; //let the form to fill the right side of the panel 
            childForm.Parent = this.pnlRight;
            childForm.Show();
        }

        private void closePreviousSelect()
        {
            foreach (Control item in this.pnlRight.Controls)
            {
                if (item is Form)
                {
                    ((Form)item).Close();
                }
            }
        }

        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            closePreviousSelect();

            FrmModifyPwd newPassword = new FrmModifyPwd();
            newPassword.FormBorderStyle = FormBorderStyle.None;
            newPassword.Dock = DockStyle.Fill;
            newPassword.TopLevel = false;
            newPassword.Parent = this.pnlRight;
            newPassword.Show();
        }
    }
}
