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
    public class TeacherService
    {
        /// <summary>
        /// Teacger Login
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        public Teacher TeacherLogin(Teacher teacher)
        {
            // 1) set SQL string
            string sql = $"select TeachereName, TeacherId from Teacher where loginAccount='{teacher.LoginAccount}' and LoginPWD='{teacher.LoginPWD}'";

            // 2) submit query
            SqlDataReader reader = SQLHelper.MultiQuery(sql);

            // 3) check if login password is correct, if yes then get ID and Name
            if (reader.Read())
            {
                teacher.TeacherId = Convert.ToInt32( reader["TeacherId"]);
                teacher.TeacherName = reader["TeachereName"].ToString();
            }
            else
            {
                teacher = null;
            }

            // 4) Close reader
            reader.Close();
            return teacher;
        }

        public int ChangePwd(Teacher teacher, string newpassword)
        {
            string sql = $"update Teacher set LoginPWD='{newpassword}'";
            sql += $" where TeacherId={teacher.TeacherId}";

            return SQLHelper.Update(sql);
        } 
    }
}
