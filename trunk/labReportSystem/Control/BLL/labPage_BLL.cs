using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using labReportSystem.Control.DAL;

namespace labReportSystem.Control.BLL
{
    public class labPage_BLL
    {
        /// <summary>
        /// 提交数据到数据库中
        /// </summary>
        /// <param name="teaname">教室姓名</param>
        /// <param name="local">地点</param>
        /// <param name="year">实验</param>
        /// <returns></returns>
        public bool CommitData(string teaname,string location,string year)
        {
            return new labPage_DAL().CommitData(teaname, location, year);
        }
    }
}