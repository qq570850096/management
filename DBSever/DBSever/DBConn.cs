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
    
    //接口泛型化
    interface InterCour<T>
    {
        //接口成员增删改查
       string AddC(T C);
       DataTable SC();
       string upC(T C);
       Course SelectC(T C);
    }
    public class InterC : InterCour<Course>
    {
        public string AddC(Course C)
        {
            DataClasses1DataContext DC = new DataClasses1DataContext();
            DC.Course.InsertOnSubmit(C);
            try
            {
                DC.SubmitChanges();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "添加课程成功！";
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
        public Course SelectC(Course C)
        {
            DataClasses1DataContext DC = new DataClasses1DataContext();
            var q = DC.Course.Where(p => p.C_Num == C.C_Num);
            if (q.Count() > 0)
            {
                C = q.First();
                return C;
            }
            else
                return null;
        }
        public string upC(Course C)
        {
            DataClasses1DataContext DC = new DataClasses1DataContext();
            var q = DC.Course.Where(p => p.C_Num == C.C_Num);
            if (q!= null)
            {
                q.First().C_Name = C.C_Name;
                q.First().C_Score = C.C_Score;
                q.First().C_Team = C.C_Team;
                q.First().C_Year = C.C_Year;
                q.First().C_Time = C.C_Time;
                DC.SubmitChanges();
                return "课程信息修改成功！";
            }
            else
                return "课号信息有误，不存在该课程";
        }
    }
}
