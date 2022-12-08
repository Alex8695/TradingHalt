using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HALT_CODE = TradingHaltAPI.Model.HaltCode;

namespace TradingHaltAPI
{
	public partial class TradingHalt
	{
		/// <summary>
		/// <c>HaltCodes</c>
		/// <para>Collection Of Halt Codes With Description</para>
		/// </summary>
		public static readonly HALT_CODE[] HaltCodes = Control.HaltCode.HaltCodes;
	}
}
