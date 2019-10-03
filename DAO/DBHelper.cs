using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class DBHelper
    {
        static string conStr = @"Data Source=.;Initial Catalog=T6;Integrated Security=True";

        public static void WriteLog(Exception ex)
        {
            using (StreamWriter sw = new StreamWriter("错误日志.txt", true))
            {
                sw.WriteLine("错误内容：" + ex.Message);
                sw.WriteLine("错误时间:" + DateTime.Now);
                sw.WriteLine("错误文件:Form1");
            }
        }

        public static DataTable GetTable(string sql, params SqlParameter[] ps)
        {
            SqlConnection cn = new SqlConnection(conStr);
            SqlDataAdapter ad = new SqlDataAdapter(sql, cn);
            if (ps != null)
            {
                ad.SelectCommand.Parameters.AddRange(ps);
            }
            DataTable dt = new DataTable();
            try
            {
                ad.Fill(dt);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dt;
        }
        public static DataTable GetFenYe(string sql, params SqlParameter[] ps)
        {
            SqlConnection cn = new SqlConnection(conStr);

            SqlDataAdapter ad = new SqlDataAdapter(sql, cn);
            if (ps != null)
            {
                ad.SelectCommand.Parameters.AddRange(ps);
            }
            //执行的是存储过程
            ad.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            try
            {
                ad.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dt;
        }

        public static int InsertUpdateDelete(string sql, params SqlParameter[] ps)
        {
            int reuslt = 0;
            using (SqlConnection cn = new SqlConnection(conStr))
            {

                SqlCommand cmd = new SqlCommand(sql, cn);
                if (ps != null)
                {
                    cmd.Parameters.AddRange(ps);
                }
                try
                {
                    cn.Open();
                    reuslt = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            return reuslt;
        }
        public static object SelectSing(string sql, params SqlParameter[] ps)
        {
            object reuslt = 0;
            using (SqlConnection cn = new SqlConnection(conStr))
            {

                SqlCommand cmd = new SqlCommand(sql, cn);
                if (ps != null)
                {
                    cmd.Parameters.AddRange(ps);
                }
                try
                {
                    cn.Open();
                    reuslt = cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {

                    WriteLog(ex);
                }
            }
            return reuslt;
        }

        public static SqlDataReader SelectReader(string sql, params SqlParameter[] ps)
        {
            SqlDataReader reuslt = null;
            SqlConnection cn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(sql, cn);
            if (ps != null)
            {
                cmd.Parameters.AddRange(ps);
            }
            try
            {
                cn.Open();
                reuslt = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {

                WriteLog(ex);
            }

            return reuslt;
        }


        public static DataTable SelectXlk(string sql)
        {
            SqlConnection con = new SqlConnection(conStr);
            SqlDataAdapter sta = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            sta.Fill(dt);
            return dt;
        }

        public static object SelectRows(string sql)
        {
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            object obj = cmd.ExecuteScalar();
            con.Close();
            return obj;
        }
    }
}
