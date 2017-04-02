using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using labReportSystem.Control.BLL;

namespace labReportSystem.Control.Webservice
{
    /// <summary>
    /// LabPage_Main 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class LabPage_Main : System.Web.Services.WebService
    {

        /// <summary>
        /// 数据的提交
        /// </summary>
        /// <param name="teaName">教师名</param>
        /// <param name="local">地点</param>
        /// <param name="year">实验日期</param>
        [WebMethod]
        public void CommitData( string teaName,string local,string year )
        {
            
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns></returns>
        [WebMethod]
        public string GetUserDate(string username)
        {
            return new labPage_BLL().GetUserDate(username);
        }
    }
}
