﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Website: http://www.freesql.net
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace Atlass.Framework.Models
{

	[JsonObject(MemberSerialization.OptIn)]
	public partial class sys_department
	{
		[JsonProperty, Column(IsIdentity = true)]
		public int id { get; set; }

		[JsonProperty, Column(DbType = "int(11)")]
		public int department_level { get; set; }

		[JsonProperty]
		public string department_name { get; set; } = string.Empty;

		[JsonProperty, Column(DbType = "int(11)")]
		public int department_type { get; set; }


		[JsonProperty]
		public long insert_id { get; set; }

		[JsonProperty, Column(DbType = "datetime")]
		public DateTime insert_time { get; set; }

		[JsonProperty]
		public int parent_id { get; set; }

		[JsonProperty]
		public int sort_num { get; set; }

	}

}