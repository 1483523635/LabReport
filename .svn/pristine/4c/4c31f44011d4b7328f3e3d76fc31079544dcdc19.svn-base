using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace labReportSystem.Control.DAL
{
    public class Users_DAL
    {

        /// <summary>
        /// 判断账号和密码是否一致
        /// </summary>
        /// <param name="name">账号名称</param>
        /// <param name="pwd">密码</param>
        /// <returns>bool</returns>
        public bool Junge(string name, string pwd)
        {
            SqlDB sqlDb=new SqlDB();
            DataTable table = new SqlDB().FillDt("select count(*) from Users where Users_name='"+name+"'and Users_pwd='"+pwd+"'");
            if (table.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            return false;
        }
    }
}