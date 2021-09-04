using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManageDAL;
using CourseManageModels;

namespace CourseManageBLL
{
    public class TeacherManage
    {
        private TeacherService teacherService = new TeacherService();
        public Teacher TeacherLogin(Teacher teacher)
        {
            return teacherService.TeacherLogin(teacher);            
        }

        public int ChangePwd(Teacher teacher, string newpassword)
        {
            return teacherService.ChangePwd(teacher, newpassword);
        }
    }
}
