using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DBSever
{
    class userinfo
    {
        public bool Login(string user_id,string pwd)
        {
            //拼接T_SQL语句
            string strSQL="SELECT * FROM userinfo WHERE user_id='" + user_id + "' AND user_pwd='" + pwd + "'";
            //执行SQL语句
            DBConn dbconn = new DBConn();//实例化连接数据库的类的对象
            SqlConnection conn=dbconn.OpenConn();//调用对象中的打开数据库方法
            SqlCommand comm = new SqlCommand(strSQL, conn);//实例化SQLcommand对象

            SqlDataReader dr=comm.ExecuteReader();//执行Sql语句，并接受返回受影响的行数
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
                                           ('"+user_id+@"'
                                           ,'"+pwd+@"'
                                           ,'"+ip_addr+@"'
                                           ,'"+mac_addr+@"'
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
}
