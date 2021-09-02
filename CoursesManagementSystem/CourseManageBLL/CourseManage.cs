using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManageModels;
using CourseManageDAL;

namespace CourseManageBLL
{
    public class CourseManage
    {
        public CourseService courseService = new CourseService();
        public int AddCourse(Course course)
        {
            return courseService.AddCourse(course);
        }
    }
}
