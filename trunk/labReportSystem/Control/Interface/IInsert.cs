using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace labReportSystem.Control.Interface
{
    /// <summary>
    /// 执行基础的插入sql语句
    /// </summary>
    public interface IInsert
    {
        /// <summary>
        /// 执行sql插入语句
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="sqlInsert">sql语句</param>
        /// <returns>受影响行数</returns>
        int Insert<T>(T sqlInsert);
    }
}
