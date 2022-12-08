using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TradingHaltLibrary.Model
{
	public partial class HaltCode
	{
		/// <summary>
		/// <c>HaltCode</c>
		/// <para>Halt Code Details</para>
		/// </summary>
		[DebuggerDisplay("{Code} : {Desc}")]
		public class HaltCodeItem
		{
			[JsonPropertyName("code")]
			public string Code { get => code; set => code = value; }

			[JsonPropertyName("desc")]
			public string Desc { get => symbol; set => symbol = value; }

			[JsonPropertyName("detail")]
			public string DescDetail { get => symbolDetail; set => symbolDetail = value; }

			private string code;
			private string symbol;
			private string symbolDetail;

			public HaltCodeItem() { }
		}
	}
}
