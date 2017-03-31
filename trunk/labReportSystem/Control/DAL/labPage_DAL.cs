using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using labReportSystem.Model;

namespace labReportSystem.Control.DAL
{
    public class labPage_DAL
    {
        public bool InsertData(LabReport model)
        {   
            string sql = "insert into  LabReport vlues("+
                         model.LabReport_userid+",'"+model.LabReport_subname+ "','"+
                         model.LabReport_teaname + "','" +model.LabReport_location +
                         "','" +model.LabReport_date + "','" +model.LabReport_fill+"')";
            return new SqlDB().ExecSql(sql);
        }
        public bool UpdateData(LabReport model)
        {
            string sql = "update  LabReport set ";
            //这里没有完成 明天继续
            return new SqlDB().ExecSql(sql);
        }
    }
}