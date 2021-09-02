using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseManageBLL;
using CourseManageModels;

namespace CourseMgtPage1
{
    public partial class FrmAddCourse : Form
    {
        private CourseCategoryManage courseCategoryManager = new CourseCategoryManage();
        private CourseManage courseManage = new CourseManage();
        List<Course> addedCourse = new List<Course>(); //buffer to save added course information
        public FrmAddCourse()
        {
            InitializeComponent();
            this.cbbCategory.DataSource = courseCategoryManager.getCourseCategories();
            this.cbbCategory.DisplayMember = "Course_Category_Name";
            this.cbbCategory.ValueMember = "Course_Category_Id";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            if(this.txtCourseName.Text==""|| this.txtCourseContent.Text == "" || this.txtClassHours.Text == "" || this.txtCredit.Text == "")
            {
                MessageBox.Show("Please fill in the blanks for Course details!","Empty Information!", MessageBoxButtons.OK);

            }
            if (this.cbbCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select course category from the Category drop list", "Missing Selections", MessageBoxButtons.OK);
            }

            Course course = new Course {
                CourseName = this.txtCourseName.Text.Trim(),
                CourseContent = this.txtCourseContent.Text.Trim(),
                CourseHours = Convert.ToInt32(this.txtClassHours.Text.Trim()),
                Credit = Convert.ToInt32(this.txtCredit.Text.Trim()),
                CategoryId = (int)this.cbbCategory.SelectedValue,
                TeacherId = Program.currentTeacher.TeacherId,
                CategoryName = this.cbbCategory.Text
                };

            // call backend to save to DB           
            int result = courseManage.AddCourse(course);

            // add data to buffer, and setup datasource for Datagridview
            addedCourse.Add(course);
            this.dvgAddCourse.DataSource = null;
            this.dvgAddCourse.DataSource = addedCourse;
            this.dvgAddCourse.AutoGenerateColumns = false;

            if (this.ckbAutoClear.Checked)
            {
                this.txtCourseName.Text = "";
                this.txtCourseContent.Text = "";
                this.txtClassHours.Text = "";
                this.txtCredit.Text = "";
                this.cbbCategory.SelectedIndex = 0;
            }

        }
    }
}
