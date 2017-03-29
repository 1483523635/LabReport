using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using labReportSystem.Control.Interface;

namespace labReportSystem.Control.DAL
{
    /// <summary>
    /// 执行sql 语句基础工厂
    /// </summary>
    public class baseSqlFactory_DAL : ISelect, IInsert, IUpdate, IDelete
    {
        private SqlDB sqlDb = null;
        public baseSqlFactory_DAL()
        {
            sqlDb = new SqlDB();
        }
        /// <summary>
        /// 执行查询语句
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="sqlSelect">sql语句</param>
        /// <returns>DT</returns>
        public System.Data.DataTable SelectData<T>(T sqlSelect)
        {
            return sqlDb.FillDt(sqlSelect as string);
        }
        /// <summary>
        /// 执行插入语句
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="sqlInsert">sql语句</param>
        /// <returns>受影响行数</returns>
        public int Insert<T>(T sqlInsert)
        {
            return sqlDb.ExecSql(sqlInsert as string)==true?1:0;
        }
        /// <summary>
        /// 执行更新语句
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="sqlUpdate">sql语句</param>
        /// <returns>受影响行数</returns>
        public int Update<T>(T sqlUpdate)
        {
            return sqlDb.ExecSql(sqlUpdate as string) == true ? 1 : 0;
        }
        /// <summary>
        /// 执行删除语句
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="sqlDelete">sql语句</param>
        /// <returns>受影响行数</returns>
        public int Delete<T>(T sqlDelete)
        {
            return sqlDb.ExecSql(sqlDelete as string) == true ? 1 : 0;
        }
    }
}