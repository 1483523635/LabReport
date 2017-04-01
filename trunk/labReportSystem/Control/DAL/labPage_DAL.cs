using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using labReportSystem.Model;

namespace labReportSystem.Control.DAL
{
    public class labPage_DAL
    {
        /// <summary>
        /// 向LabReport表中的添加一条数据
        /// 时间：2017-3-17
        /// author： 曲
        /// </summary>
        /// <param name="model">实体类</param>
        /// <returns>是否成功</returns>
        public bool InsertData(LabReport model)
        {   
            string sql = "insert into  LabReport vlues("+
                         model.LabReport_userid+",'"+model.LabReport_subname+ "','"+
                         model.LabReport_teaname + "','" +model.LabReport_location +
                         "','" +model.LabReport_date + "','" +model.LabReport_fill+"')";
            return new SqlDB().ExecSql(sql);
        }
        /// <summary>
        /// 更新表LabReport数据
        /// 时间：2017-3-17
        /// author：曲
        /// </summary>
        /// <param name="model">该表对应的实体类</param>
        /// <returns>是否成功</returns>
        public bool UpdateData(LabReport model)
        {
            string sql = "update  LabReport set "+ "LabReport_userid='"+model.LabReport_userid+ 
                "',LabReport_subname='"+model.LabReport_subname+
                "',LabReport_teaname='"+model.LabReport_teaname+
                "',LabReport_location='"+model.LabReport_location+
                "',LabReport_date='"+model.LabReport_date+
                "',LabReport_fill='"+model.LabReport_fill+
                 "where LabReport_id=" + model.LabReport_userid;
            return new SqlDB().ExecSql(sql);
        }
    }
}