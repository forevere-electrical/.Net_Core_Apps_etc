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
        private CourseService courseService = new CourseService();
        
        public int AddCourse(Course course)
        {
            return courseService.AddCourse(course);
        }

        public List<Course> CourseQuery(int categoryId, string courseName)
        {
            return courseService.QueryCourse(categoryId, courseName);
        }

        public int ModifyCourse(Course course)
        {
            return courseService.ModifyCourse(course);
        }
    }
}
