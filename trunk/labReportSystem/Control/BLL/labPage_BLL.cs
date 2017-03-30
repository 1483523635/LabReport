using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using labReportSystem.Control.DAL;
using labReportSystem.Model;

namespace labReportSystem.Control.BLL
{
    public class labPage_BLL
    {
        /// <summary>
        /// 提交数据到数据库中
        /// </summary>
        /// <param name="modelReport">实验报告册LabReport实体类</param>
        /// <returns></returns>
        public bool CommitData(LabReport modelReport)
        {
            if(数据存在)
                进行更新
            else 进行插入
            return new labPage_DAL().CommitData(modelReport);
        }
    }
}