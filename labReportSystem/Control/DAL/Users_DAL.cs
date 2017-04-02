using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace labReportSystem.Control.DAL
{
    public class Users_DAL
    {
        protected SqlDB SqlDb;
        public Users_DAL()
        {
            SqlDb = new SqlDB();
        }
        /// <summary>
        /// 判断账号和密码是否一致
        /// </summary>
        /// <param name="name">账号名称</param>
        /// <param name="pwd">密码</param>
        /// <returns>bool</returns>
        public bool Junge(string name, string pwd)
        {    
            DataTable table = SqlDb.FillDt("select count(*) from Users where Users_name='"+name+"'and Users_pwd='"+pwd+"'");
            if (table.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 通过用户名获取用户的ID
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns>用户ID</returns>
        public string GetUserId(string username)
        {
            string sql = "select Users_ID  from Users where users_name='"+ username+"'";
            DataTable dt = SqlDb.FillDt(sql);
            return dt.Rows[0]["Users_ID"].ToString();
        }
    }
}