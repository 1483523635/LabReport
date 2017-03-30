using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace labReportSystem.Control.Interface
{
    /// <summary>
    /// 基础的查询sql语句
    /// </summary>
    public interface ISelect
    {
        /// <summary>
        /// 执行基础的查询sql语句
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="sqlSelect">sql语句</param>
        /// <returns>DT</returns>
        DataTable SelectData<T>(T sqlSelect);
    }
}
