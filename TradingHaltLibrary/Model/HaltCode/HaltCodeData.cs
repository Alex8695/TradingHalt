using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingHaltLibrary.Model
{
	public partial class HaltCode
	{
		public static string HaltCodeJson { get { return getHaltCodeRaw(); } }
		
		private static string getHaltCodeRaw()
		{
			return System.Text.Encoding.UTF8.GetString(
				bytes: Properties.Resources.halt_code);
		}

	}
}
