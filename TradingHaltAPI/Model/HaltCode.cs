using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HALT_CODE = TradingHaltLibrary.Model.HaltCode.HaltCodeItem;


namespace TradingHaltAPI.Model
{
	/// <summary>
	/// <c>HaltCode</c>
	/// <para>Halt Code Details</para>
	/// </summary>
	[DebuggerDisplay("{Code} : {Desc}")]
	public class HaltCode  : HALT_CODE
	{
		public override string ToString()
		{
			return $"{this.Code}: {this.Desc}";
		}

		public HaltCode() { }

		internal HaltCode(HALT_CODE halt_code)
		{

			this.Code = halt_code.Code;
			this.Desc = halt_code.Desc;
			this.DescDetail = halt_code.DescDetail;

		}
	}
}
