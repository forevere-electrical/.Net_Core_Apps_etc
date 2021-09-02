using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CourseManageModels;

namespace CourseManageDAL
{
    public class CourseService
    {
        /// <summary>
        /// Insert new course into DB by using @parameter method in sql
        /// </summary>
        /// <returns> rows affected </returns>
        public int AddCourse(Course course)
        {
            //1. complete query sql with @parameters:
            string sql = "insert into Course (CourseName, CourseContent, CourseHours, Credit, CategoryId, TeacherId";
            sql += " values (@CourseName, @CourseContent, @CourseHours, @Credit, @CategoryId, @TeacherId";

            //2. connect Parameters array to @parameters
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CourseName", course.CourseName),
                new SqlParameter("@CourseContent", course.CourseContent),
                new SqlParameter("@CourseHours", course.CourseHours),
                new SqlParameter("@Credit", course.Credit),
                new SqlParameter("@CategoryId", course.CategoryId),
                new SqlParameter("@TeacherId", course.TeacherId)
            };

            // get result by using SQL HELPER(Need new default arguments)
            return SQLHelper.Update(sql, param);
        }
    }
}
