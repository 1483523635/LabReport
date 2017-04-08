using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace labReportSystem.Common
{
    public class TypeHelper
    {
        private static MethodInfo GetMethod(Type t, string methodName)
        {
            return t.GetMethod(methodName);
        }

        /// <summary>
        /// 获取表名
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string getTableName(Type t)
        {
            //使用说明如果表明和类名相同 请使用
            return GetClassName(t);

            //如果表名和类名不同请使用这个方法
            //MethodInfo talbeInfo = GetMethod(t, "GetTableName");
            //string tableName = talbeInfo.Invoke(null, null) as string;
            //return tableName;

        }

        /// <summary>
        /// 获取类的名称
        /// </summary>
        /// <param name="type">类型</param>
        /// <returns></returns>
        private static string GetClassName(Type type)
        {
            return type.Name;
        }

        /// <summary>
        /// 获取所有的属性
        ///  已过时
        /// </summary>
        /// <param name="t">类型</param>
        /// <returns></returns>
        public static string[] GetAttrs(Type t)
        {
            //MethodInfo method = GetMethod(t, "GetAttrNames");
            //string[] attrs = method.Invoke(null, null) as string[];
            //return attrs;
            return GetPropertyNameAll(t).ToArray();
        }

        /// <summary>
        /// 获取主键
        /// </summary>
        /// <param name="t">类型</param>
        /// <returns></returns>
        public static string GetPK(Type t)
        {
            MethodInfo method = GetMethod(t, "GetPkFieldName");
            return method.Invoke(null, null) as string;
        }

        /// <summary>
        /// 获取属性info
        /// </summary>
        /// <param name="t">类型</param>
        /// <param name="propertyName">属性名称</param>
        /// <returns></returns>
        private static PropertyInfo GetPropertyInfo(Type t, string propertyName)
        {
            return t.GetProperty(propertyName);
        }

        /// <summary>
        /// 获取属性的值
        /// </summary>
        /// <param name="obj">类</param>
        /// <param name="propertyName">字段名称</param>
        /// <returns>object</returns>
        public static object GetPropertyValue(object obj, string propertyName)
        {
            Type t = obj.GetType();
            PropertyInfo property = obj.GetType().GetProperty(propertyName);
            var values = property.GetValue(obj);   
            return values;
        }
        /// <summary>
        /// 设置该属性的值
        /// </summary>
        /// <param name="obj">类</param>
        /// <param name="propertyName">字段名称</param>
        /// <param name="data">设置数据</param>
        /// <returns></returns>
        public static void SetPropertyValue(object obj, string propertyName, string data)
        {
            PropertyInfo property = obj.GetType().GetProperty(propertyName);
            property.SetValue(obj, data);
        }
        /// <summary>
        /// 获取所有的属性的值
        /// </summary>
        /// <typeparam name="T">返回的类型</typeparam>
        /// <param name="obj">实例化的类</param>
        /// <returns>List</returns>
        public static List<T> GetPropertyValues<T>(object obj)
        {
            Type t = obj.GetType();
            PropertyInfo[] property = getPropertyInfoAll(t);
            List<T> list = new List<T>();
            foreach (var item in property)
            {
                list.Add((T)item.GetValue(obj));
            }
            return list;
        }
        /// <summary>
        /// 获取所有的属性列表
        /// </summary>
        /// <param name="t">类型</param>
        /// <returns></returns>
        private static PropertyInfo[] getPropertyInfoAll(Type t)
        {
            return t.GetProperties();
        }

        /// <summary>
        /// 获取所有的属性的名字
        /// </summary>
        /// <param name="type">类型</param>
        /// <returns></returns>
        public static List<string> GetPropertyNameAll(Type type)
        {
            var propertyInfo = getPropertyInfoAll(type);
            List<string> list = new List<string>();

            foreach (var item in propertyInfo)
            {
                list.Add(item.Name);
            }
            return list;
        }
        #region 获取主键和值

        /// <summary>
        /// 获取主键和值
        /// 返回的第一个参数代表主键的字段名称
        /// 返回的第二个参数代表主键的值
        /// </summary>
        /// <param name="obj">实例化的类</param>
        /// <returns></returns>
        public static Tuple<string, string> GetPkNameAndValues(object obj)
        {
            Type type = obj.GetType();
            string Pk = GetPK(type);
            var pkValues = GetPropertyValue(obj, Pk).ToString();
            return Tuple.Create(Pk, pkValues);
        }

        #endregion
    }
}