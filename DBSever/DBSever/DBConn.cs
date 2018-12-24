using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DBSever
{
    public class DBConn
    {

        SqlConnection conn;
        public SqlConnection OpenConn()
        {
            //创建连接

            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = "localhost";
            scsb.UserID = "sa";
            scsb.Password = "123456";
            scsb.InitialCatalog = "HrSystem";

            //判断连接是否打开
            conn = new SqlConnection(scsb.ToString());//参数是连接数据库的字符串 
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();

            return conn;
        }

    }
    public class userinfoService
    {
        public bool Login(string user_id, string pwd)
        {
            //拼接T_SQL语句
            string strSQL = "SELECT * FROM userinfo WHERE user_id='" + user_id + "' AND user_pwd='" + pwd + "'";
            //执行SQL语句
            DBConn dbconn = new DBConn();//实例化连接数据库的类的对象
            SqlConnection conn = dbconn.OpenConn();//调用对象中的打开数据库方法
            SqlCommand comm = new SqlCommand(strSQL, conn);//实例化SQLcommand对象

            SqlDataReader dr = comm.ExecuteReader();//执行Sql语句，并接受返回受影响的行数
            if (dr.Read())//如果能前进到下一行说明可以登录
                return true;
            return false;
        }
        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="user_id"></param>
        /// <param name="pwd"></param>
        /// <param name="ip_addr"></param>
        /// <param name="mac_addr"></param>
        /// <returns></returns>
        public string Register(string user_id, string pwd, string ip_addr, string mac_addr)
        {
            //拼接T_SQL语句
            string strSQL = @"INSERT INTO [HrSystem].[dbo].[userinfo]
                                           ([user_id]
                                           ,[user_pwd]
                                           ,[ip_addr]
                                           ,[mac_addr])

                                     VALUES
                                           ('" + user_id + @"'
                                           ,'" + pwd + @"'
                                           ,'" + ip_addr + @"'
                                           ,'" + mac_addr + @"'
                                           )";
            //执行SQL语句
            DBConn dbconn = new DBConn();//实例化连接数据库的类的对象
            SqlConnection conn = dbconn.OpenConn();//调用对象中的打开数据库方法

            SqlCommand comm = new SqlCommand(strSQL, conn);//实例化SQLcommand对象
            try
            {
                int row_count = comm.ExecuteNonQuery();//执行Sql语句，并接受返回受影响的行数

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "注册成功！";
        }
    }
    //model对象
    //对应的是表中的属性
    public class student
    {
        public string stu_num { get; set; }
        public string stu_name { get; set; }
    }
    public class crouse
    {
        public string C_Num { get; set; }

        public string C_Name { get; set; }

        public string C_Time { get; set; }

        public string C_Score { get; set; }

        public string C_Year { get; set; }

        public string C_Team { get; set; }

        public string AddCrouse(crouse C)
        {
            //拼接T_SQL语句
            string strSQL = @"INSERT INTO [HrSystem].[dbo].[Course]
                                               ([C_Num]
                                               ,[C_Name]
                                               ,[C_Time]
                                               ,[C_Score]
                                               ,[C_Year]
                                               ,[C_Team])

                                     VALUES
                                           ('" + C.C_Num + @"'
                                           ,'" + C.C_Name + @"'
                                           ,'" + C.C_Time + @"'
                                           ,'" + C.C_Score + @"'
                                            ,'" + C.C_Year + @"'
                                            ,'" + C.C_Team + @"'
                                           )";
            //执行SQL语句
            DBConn dbconn = new DBConn();//实例化连接数据库的类的对象
            SqlConnection conn = dbconn.OpenConn();//调用对象中的打开数据库方法


            SqlCommand comm = new SqlCommand(strSQL, conn);//实例化SQLcommand对象
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                return "课号已被占用，不能重复登记";
            }
            dr.Close();
            try
            {
                int row_count = comm.ExecuteNonQuery();//执行Sql语句，并接受返回受影响的行数

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "开设课程成功";

        }
        public DataTable SC()
        {
            DBConn dbconn = new DBConn();//实例化连接数据库的类的对象
            SqlConnection conn = dbconn.OpenConn();//调用对象中的打开数据库方法
            string strSQL = "select * from [dbo].[Course]";

            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);//参数1：T-sql脚本，参数2连接数据库
            da.Fill(ds, "Course");//填充数据源
            dt = ds.Tables["Course"];//获取数据源中的表
            return dt;
        }
        public crouse SelectC(crouse C)
        {
            DBConn dbconn = new DBConn();//实例化连接数据库的类的对象
            SqlConnection conn = dbconn.OpenConn();//调用对象中的打开数据库方法
            string strSQL = "select * from [dbo].[Course] where C_Num='" + C.C_Num + "'";
            //执行Sql语句
            SqlCommand comm = new SqlCommand(strSQL, conn);
            SqlDataReader dr = comm.ExecuteReader();//执行sql语句，返回受影响的行数
            if (dr.Read())//如果能够前进到下一条记录，就说明有数据
            {
                //学号
                C.C_Num = dr["C_Num"].ToString();
                //课程名称
                C.C_Name = dr["C_Name"].ToString();
                //学时
                C.C_Time = dr["C_Time"].ToString();
                //学分
                C.C_Score = dr["C_Score"].ToString();
                //开设学年
                C.C_Year = dr["C_Year"].ToString();
                //开设学期
                C.C_Team = dr["C_Team"].ToString();
                return C;
            }
            dr.Close();

            return null;
        }
        public string upC(crouse C)
        {
            //拼接T_SQL语句

            //执行SQL语句
            DBConn dbconn = new DBConn();//实例化连接数据库的类的对象
            SqlConnection conn = dbconn.OpenConn();//调用对象中的打开数据库方法
            string strSQL = "select * from [dbo].[Course] where C_Num='" + C.C_Num + "'";

            SqlCommand comm = new SqlCommand(strSQL, conn);//实例化SQLcommand对象
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                strSQL = @"UPDATE [HrSystem].[dbo].[Course] SET
                                               [C_Num]='" + C.C_Num + @"'
                                               ,[C_Name]='" + C.C_Name + @"'
                                               ,[C_Time]='" + C.C_Time + @"'
                                               ,[C_Score]='" + C.C_Score + @"'
                                               ,[C_Year]='" + C.C_Year + @"'
                                               ,[C_Team]='" + C.C_Team + @"'

                                     WHERE [C_Num] ='" + C.C_Num + @"'";

                comm = new SqlCommand(strSQL, conn);
                try
                {
                    int row_count = comm.ExecuteNonQuery();//执行Sql语句，并接受返回受影响的行数

                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
                dr.Close();
                return "课程信息修改成功";
            }
            dr.Close();
            return "课号信息有误，不存在该课程";
        }
    }
}
