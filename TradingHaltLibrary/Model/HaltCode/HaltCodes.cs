using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TradingHaltLibrary.Model
{
	public partial class HaltCode
	{
		public class HaltCodes
		{
			[JsonPropertyName("halt_code")]
			public HaltCode.HaltCodeItem[] HaltCodeCollection { 
				get => haltCodes; 
				set => haltCodes = value; }

			private HaltCode.HaltCodeItem[] haltCodes;

			public HaltCodes() { }
		}
	}
}
