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
            string sql = "insert into Course (CourseName, CourseContent, CourseHours, Credit, CategoryId, TeacherId)";
            sql += " values (@CourseName, @CourseContent, @CourseHours, @Credit, @CategoryId, @TeacherId)";

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

        public List<Course> QueryCourse(int categoryId, string courseName)
        {
            // prepare sql for query with parameters as filters
            string sql = "select CourseId, CourseName, CourseContent, CourseHours, Credit, CategoryId, TeachereName,teacher.teacherid from Course";
            sql += " inner join Teacher on Course.TeacherID=Teacher.TeacherID where ";
            
            //prepare where clause in Sql
            string whereSql = String.Empty;
            if (categoryId != -1)
            {
                whereSql += " and CategoryId=" + categoryId;
            }

            if (courseName != "")
            {
                whereSql += $" and CourseName like '{courseName}%'";
            }
            if(whereSql.Length>0)  sql += whereSql.Substring(4);
            List<Course> course = new List<Course>();
            // query Course information
            SqlDataReader reader = SQLHelper.MultiQuery(sql);
            while (reader.Read())
            {
                course.Add(new Course
                {
                    CourseId = (int)reader["CourseId"],
                    CourseName = reader["CourseName"].ToString(),
                    CourseContent = reader["CourseContent"].ToString(),
                    Credit = (int)reader["Credit"],
                    CourseHours = (int)reader["CourseHours"],
                    CategoryId = (int)reader["categoryId"],
                    TeacherName = reader["TeachereName"].ToString(),
                    TeacherId = (int)reader["TeacherId"]
                }) ; 
            }
            reader.Close();
            return course;
        }
        /// <summary>
        /// update course information after get basic info from tables
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int ModifyCourse(Course course)
        {
            string sql = "update Course set CourseName=@CourseName, CourseContent=@CourseContent, CourseHours=@CourseHours, Credit=@Credit, CourseCategory=@CourseCategory ";
            sql += "where CourseId=@CourseId";
            SqlParameter[] param = new SqlParameter[] { 
                new SqlParameter("@CourseName",course.CategoryName),
                new SqlParameter("@CourseContent", course.CourseContent),
                new SqlParameter("@CourseHours", course.CourseHours),
                new SqlParameter("@Credit", course.Credit),
                new SqlParameter("@CategoryId", course.CategoryId),
                new SqlParameter("@CourseId", course.CourseId)            
            };

            return SQLHelper.Update(sql, param);
        }
    }
}
