using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using labReportSystem.Control.DAL;

namespace labReportSystem.Control.BLL
{
    public class userLogin_BLL
    {
        /// <summary>
        /// 判断账号和密码是否一致
        /// </summary>
        /// <param name="name">账号名</param>
        /// <param name="pwd">密码</param>
        /// <returns>bool</returns>
        public bool Login(string name, string pwd)
        {
            return new Users_DAL().Junge(name,pwd);
        }
    }
}