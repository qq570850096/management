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
    }
}
