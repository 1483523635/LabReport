using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using labReportSystem.Control.BLL;

namespace labReportSystem.Control.Webservice
{
    /// <summary>
    /// UserLogin 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class UserLogin : System.Web.Services.WebService
    {

        /// <summary>
        /// 判断账号的合法性 并将账号加到session中去
        /// user ：曲
        /// 时间 2016-12-7    21：50
        /// </summary>
        /// <param name="name">账号</param>
        /// <param name="pwd">密码</param>
        /// <returns>是否合法</returns>
        [WebMethod(EnableSession = true)]
        public bool Login(string name, string pwd)
        {
            if (new userLogin_BLL().Login(name, pwd))
            {
              
                Context.Session["User_name"] = name;
                return true;
            }
            return false;
        }

        /// <summary>
        /// 获取用户的名字 BY  Session
        /// </summary>
        /// <returns></returns>
        [WebMethod(EnableSession = true)]
        public string GetUserName()
        {
         
            string username=    Context.Session["User_name"].ToString();
            return username;
            //JavaScriptSerializer js=new JavaScriptSerializer();
            //return  js.Serialize(username);
          
        }
       
     
    }
}
