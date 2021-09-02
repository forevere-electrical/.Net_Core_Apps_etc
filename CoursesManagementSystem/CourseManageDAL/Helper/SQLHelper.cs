using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CourseManageDAL
{
    /// <summary>
    /// Common Data Access class
    /// </summary>
    class SQLHelper
    {
        private static string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        /// <summary>
        ///  insert, update, delete queries
        /// </summary>
        /// <param name="sql">sql query sentence</param>
        /// <param name="param">Array of parameters</param>
        /// <returns>rows being affected</returns>
        public static int Update(string sql, SqlParameter[] param=null)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            //added parameter defult value and check if it's null. 
            // if not , put param value into cmd
            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>

        /// execute Single result query
        /// </summary>
        /// <param name="sql"></param>
        /// return single result row
        public static object SingleQuery(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// execute mutiple result query
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>multiple result output</returns>
        public static SqlDataReader MultiQuery(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            
            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
               //remember to close connection after reader finished
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }   
}
