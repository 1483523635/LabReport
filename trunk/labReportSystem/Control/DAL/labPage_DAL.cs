using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace labReportSystem.Control.DAL
{
    public class labPage_DAL
    {
        public bool CommitData(string teaname, string location, string year)
        {
            string sql = "insert into ";
            return new SqlDB().ExecSql(sql);

        }
    }
}