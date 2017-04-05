using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace labReportSystem.Control.DAL
{
    /// <summary>
    /// 其他杂项实体类
    /// </summary>
    public class Other_DAL
    {
        private SqlDB sqlDb;

        public Other_DAL()
        {
            sqlDb=new SqlDB();
        }
        /// <summary>
        /// 获取Other表中某一列的所有值
        /// </summary>
        /// <param name="items">列名</param>
        /// <returns>DT</returns>
        public DataTable GetSomeInfo(string items)
        {
            string sql = "select "+items+" from Other order by "+items+" desc";
            return sqlDb.FillDt(sql);
        }
    }
}