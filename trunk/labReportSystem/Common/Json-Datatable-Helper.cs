using Newtonsoft.Json;
using System.Data;
namespace labReportSystem.Common
{
    /// <summary>
    /// 用户json和datatable之间的相互转化
    /// </summary>
    public static class Json_Datatable_Helper
    {
        /// <summary>
        /// Datatable转化为json
        /// 2017-4-1 8：00
        /// author ：曲
        /// </summary>
        /// <param name="table">table</param>
        /// <returns>json串</returns>
        public static string ConvertToJson(this DataTable table)
        {
            string JsonString = string.Empty;
            JsonString = JsonConvert.SerializeObject(table);
            return JsonString;

        }
        /// <summary>
        /// Json to datatable
        /// 2017-4-1 8：00
        /// author ：曲
        /// </summary>
        /// <param name="json">要转化的json串</param>
        /// <returns>DT</returns>
        public static DataTable ConvertToDatatable(this  string json)
        {
            DataTable dt = JsonConvert.DeserializeObject(json) as DataTable;
            return dt;
        }
    }
}