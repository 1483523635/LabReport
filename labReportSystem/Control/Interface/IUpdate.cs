using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace labReportSystem.Control.Interface
{
    /// <summary>
    /// 执行基础的sql更新语句
    /// </summary>
    public interface IUpdate
    { 
        /// <summary>
        /// 执行基础的更新语句
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="sqlUpdate">执行的sql语句</param>
        /// <returns>受影响行数</returns>
       int Update<T>(T sqlUpdate);
    }
}
