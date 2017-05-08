using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace labReportSystem.Common
{
    public class SqlBuilderHelper
    {

        #region 获取基础的查询语句

        /// <summary>
        /// 获取基础的查询sql语句
        /// 不带 where 
        /// 时间：2017-4-7
        /// Author：曲
        /// </summary>
        /// <param name="t">类型</param>
        /// <returns></returns>
        public static string GetBaseSelect(Type t)
        {

            string tableName = TypeHelper.getTableName(t);
            string[] attrs = TypeHelper.GetAttrs(t);
            StringBuilder selectBuilder = new StringBuilder();
            string selectstring = string.Join(",", attrs);
            selectBuilder.AppendFormat("select {0} from {1}", selectstring, tableName);
            return selectBuilder.ToString();
        }
        #endregion

        #region 获取基础的插入语句

        /// <summary>
        /// 插入查询的sql语句
        /// 注意这里有个问题、
        /// 当数据库的字段的类型为int型时 会出现错误
        /// 尚未解决 
        /// 时间：2017-4-7 
        /// Author：曲
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string GetBaseInsert(object obj)
        {
            //获取类型
            Type t = obj.GetType();
            //获取表名
            string tableName = TypeHelper.getTableName(t);


            //获取主键
            var pkandvalues = TypeHelper.GetPkNameAndValues(obj);
            string pk = pkandvalues.Item1;
            //获取字段名称数组并且去除主键
            string[] attrs = GetAttrs(t, pk);
            var pkValues = pkandvalues.Item2;
            //获取所有字段的值
            var Valuelist = new List<string>();
            Valuelist = TypeHelper.GetPropertyValues<string>(obj);
            //移除主键的值
            Valuelist.Remove(pkValues);
            //为字段的值添加   ' '  
            //原因数据库中插入值时需要  ' '
            for (int i = 0; i < Valuelist.Count; i++)
            {
                Valuelist[i] = "'" + Valuelist[i] + "'";
            }

            //生成sql语句
            StringBuilder insertString = new StringBuilder();
            string attrsString = string.Join(",", attrs);
            string values = string.Join(",", Valuelist);
            return insertString.AppendFormat("insert into {0} ({1}) values ({2})",
                                               tableName, attrsString, values).ToString();
        }
        #endregion

        #region 获取基础的修改语句

        /// <summary>
        /// 获取基础的update语句
        /// 这里出现int类型时会出现错误
        /// 时间：2017-4-7
        /// Author：曲
        /// </summary>
        /// <param name="obj">类型</param>
        /// <param name="whereString">where子句</param>
        /// <returns></returns>
        public static string GetBaseUpdate(object obj, string whereString)
        {
            Type type = obj.GetType();
            //获取表名
            string tableName = TypeHelper.getTableName(type);
            //获取主键和值
            var pkandValues = TypeHelper.GetPkNameAndValues(obj);
            string pk = pkandValues.Item1;
            //获取属性列表并去除主键
            string[] attrs = GetAttrs(type, pk);
            //获取属性的值并移除主键的值
            string[] values = GetAttrsValues(obj, pk);
            //合并属性和值
            string[] attrAndValue = MergeAttrsAndValue(attrs, values);

            //生成sql语句
            StringBuilder stringBuilder = new StringBuilder();
            string attrAndValueString = string.Join(",", attrAndValue);
            stringBuilder.AppendFormat("update {0} set {1} {2}", tableName, attrAndValueString, whereString);
            return stringBuilder.ToString();
        }
        #endregion

        #region 获取基础的删除语句

        /// <summary>
        /// 通过主键删除一条记录
        /// </summary>
        /// <param name="obj">实体类</param>
        /// <returns></returns>
        public static string GetBaseDelate(object obj)
        {
            //获取类型
            var type = obj.GetType();
            //获取表名
            string tableName = TypeHelper.getTableName(type);
            //获取主键和主键的值
            var pkAndValue = TypeHelper.GetPkNameAndValues(obj);
            string pk = pkAndValue.Item1;
            string pkValues = pkAndValue.Item2;
            //获取wherestring 
            string wherestring = MergeAttrAndValue(pk, pkValues);
            //生成sql语句
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("delete from {0} where {1}", tableName, wherestring);
            return stringBuilder.ToString();
        }

        #endregion

        #region 内部需要的方法

        #region 获取指定属性的列表
        /// <summary>
        /// 获取指定属性的列表
        /// </summary>
        /// <param name="t">类型</param>
        /// <param name="but">去除的属性</param>
        /// <returns></returns>
        private static string[] GetAttrs(Type t, params string[] but)
        {
            string[] attrs = TypeHelper.GetAttrs(t);
            var attrlist = attrs.ToList();
            //移除主键
            foreach (string t1 in but)
            {
                attrlist.Remove(t1);
            }
            return attrlist.ToArray();
        }


        #endregion

        #region 获取指定属性的值列表

        /// <summary>
        /// 获取去除指定属性列表的值
        /// </summary>
        /// <param name="t">类型</param>
        /// <param name="but">需要去除值的属性名</param>
        /// <returns></returns>
        private static string[] GetAttrsValues(object obj, params string[] but)
        {
            Type type = obj.GetType();
            var Valuelist = new List<string>();
            //待移除的属性的值列表
            //List<object> Values = new List<object>();
            ////获取所有需要移除的属性的值
            //for (int i = 0; i < but.Length; i++)
            //{
            //    Values.Add(TypeHelper.GetPropertyValue(obj, but[i]));
            //}

            //获取需要移除的值List
            var Values = but.Select(t => TypeHelper.GetPropertyValue(obj, t));
            //获取所有属性的值的列表
            Valuelist = TypeHelper.GetPropertyValues<string>(obj);
            foreach (var item in Values)
            {
                Valuelist.Remove(item.ToString());
            }
            return Valuelist.ToArray();
        }


        #endregion

        #region 将字段和值连接成 attr='value'的形式
        /// <summary>
        /// 将字段和值连接成 attr='value'的形式
        /// 注意 两个数组长度要一样
        /// 时间：2017-4-8
        /// Author：曲
        /// </summary>
        /// <param name="attrs">字段数组</param>
        /// <param name="values">值数组</param>
        /// <returns>目的字符串</returns>
        private static string[] MergeAttrsAndValue(string[] attrs, string[] values)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < attrs.Length; i++)
            {
                list.Add(MergeAttrAndValue(attrs[i], values[i]));
            }
            return list.ToArray();
        }

        /// <summary>
        /// 将两个字符串合并成 attr='value'的形式
        /// </summary>
        /// <param name="attr">第一个字符串</param>
        /// <param name="value">第二个字符串</param>
        /// <returns></returns>
        private static string MergeAttrAndValue(string attr, string value)
        {
            return attr + "='" + value + "'";
        }
        #endregion

        #endregion
    }
}