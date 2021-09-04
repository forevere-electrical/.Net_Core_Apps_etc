using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseManageModels;
using CourseManageBLL;

namespace CourseMgtPage1
{
    public partial class FrmModifyPwd : Form
    {
        private TeacherManage teacherManage = new TeacherManage();
        
        public FrmModifyPwd()
        {

            InitializeComponent();
        }


        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            // verify if password is valid, may use regular expression to validate
            if (this.txtConfirmNewPwd.Text == "" || this.txtNewPwd.Text == "" || this.txtConfirmNewPwd.Text == "")
            {
                MessageBox.Show("Password can not be empty!");
                return;
            }
            if (this.txtNewPwd.Text != this.txtConfirmNewPwd.Text)
            {
                MessageBox.Show("New password does not match");
                return;
            }
            if(this.txtOldPwd.Text != Program.currentTeacher.LoginPWD)
                // !Program.currentTeacher.LoginPWD.Equals(this.txtOldPwd.Text.Trim())
            {
                MessageBox.Show("Old password does not match!");
                this.txtOldPwd.Focus();
                return;
            }
            if (this.txtNewPwd.Text.Length < 6 || this.txtNewPwd.Text.Length > 18)
            {
                MessageBox.Show("Password need to be at 1east 6 letters and at most 18 letters.");
                return;
            }

            // get basic query information
            string newPwd = this.txtNewPwd.Text;
            Teacher teacher = new Teacher {
                TeacherId = Program.currentTeacher.TeacherId,
                LoginPWD = this.txtNewPwd.Text.Trim()
            };


            int result = teacherManage.ChangePwd(teacher);
            if(result == 1)
            {
                MessageBox.Show("Password changed!");
                Program.currentTeacher.LoginPWD = newPwd;
            }
            else
            {
                MessageBox.Show("Oops, Password change failed!");
            }
            this.txtNewPwd.Text = "";
            this.txtOldPwd.Text = "";
            this.txtConfirmNewPwd.Text = "";
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
