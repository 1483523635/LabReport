using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace labReportSystem.Model
{
	/// <summary>
	/// 实验项目详细内容类
	/// </summary>
	public class labDetail
	{
		#region 成员

		private int labcount;
		private int ldtl_teainfo_ID;
		private string labContent;
		private string ldtl_Subject;

		#endregion

		#region 属性

		/// <summary>
		/// 主键
		/// </summary>
		public int Labcount
		{
			get { return labcount; }
			set { labcount = value; }
		}
		/// <summary>
		/// 外键表示身份
		/// </summary>
		public int Ldtl_teainfo_ID
		{
			get { return ldtl_teainfo_ID; }
			set { ldtl_teainfo_ID = value; }
		}
		/// <summary>
		/// 实验内容
		/// </summary>
		public string LabContent
		{
			get { return labContent; }
			set { labContent = value; }
		}
		/// <summary>
		/// 外键
		/// </summary>
		public string Ldtl_Subject
		{
			get { return ldtl_Subject; }
			set { ldtl_Subject = value; }
		}

		#endregion

		#region 方法

		/// <summary>
		///返回表名
		/// </summary>
		/// <returns></returns>
		public string GetTableName()
		{
			return "labDetail";
		}
		/// <summary>
		///返回主键字段名
		/// </summary>
		/// <returns></returns>
		public string GetPkFieldName()
		{
			return "Labcount";
		}
		/// <summary>
		///返回全路径类名
		/// </summary>
		/// <returns></returns>
		public string GetFullClassName()
		{
			return "labReportSystem.Model.labDetail";
		}
		/// <summary>
		///返回属性列表
		/// </summary>
		/// <returns></returns>
		public string[] GetAttrNames()
		{
			return new string[]{ "Labcount", "Ldtl_teainfo_ID", "LabContent", "Ldtl_Subject" };
		}

		#endregion
	}
}

