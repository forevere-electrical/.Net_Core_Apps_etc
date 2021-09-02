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
    public class CourseCategoryService
    {
        /// <summary>
        /// get results from course caterogy list.
        /// </summary>
        /// <returns>a list of course categories in List<CourseCategory> format</returns>
        public List<Course_Category> getCourseCategories()
        {
            string sql = "select Course_Category_Id, Course_Category_Name from Course_Category";
            List<Course_Category> list = new List<Course_Category>();
            SqlDataReader reader = SQLHelper.MultiQuery(sql);
            while (reader.Read())
            {
                list.Add(new Course_Category
                {
                    Course_Category_Id = (int)reader["Course_Category_Id"],
                    Course_Category_Name = reader["Course_Category_Name"].ToString()
                });
            }
            reader.Close();
            return list;
        }
    }
}
