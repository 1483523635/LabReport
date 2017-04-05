using labReportSystem.Control.BLL;
using System.Web.Services;

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
        /// <summary>
        /// 通过科目名称获取实验次数
        /// 时间：2017-4-4
        /// Author ：曲
        /// </summary>
        /// <param name="subjectName"></param>
        /// <returns></returns>
        [WebMethod]
        public int GetLabCount(string subjectName)
        {
            return new labPage_BLL().GetLabCount(subjectName);
        }

        /// <summary>
        /// 通过科目名称获取老师姓名
        /// </summary>
        /// <param name="subjectName">科目名称</param>
        /// <returns>Json串</returns>
        [WebMethod]
        public string GetTeacherList(string subjectName)
        {
            return new labPage_BLL().GetTeaNameList(subjectName);
        }

        /// <summary>
        ///获取所有的学年学期
        /// </summary>
        /// <returns>JSON</returns>
        [WebMethod]
        public string GetAllScheme()
        {
            return new labPage_BLL().GetAllScheme();
        }
    }
}
