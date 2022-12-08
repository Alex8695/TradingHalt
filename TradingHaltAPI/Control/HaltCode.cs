using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static TradingHaltLibrary.Model.HaltCode;
using HALT_CODE_LIB = TradingHaltLibrary.Model.HaltCode;
using HALT_CODE = TradingHaltAPI.Model.HaltCode;
using System.Net.NetworkInformation;

namespace TradingHaltAPI.Control
{
	static partial class HaltCode
	{
		/// <summary>
		/// <c>HaltCodes</c>
		/// <para>Reference Collection Of Halt Codes With Description</para>
		/// </summary>
		public static HALT_CODE[] HaltCodes { get => haltCodes; }


		private static readonly HALT_CODE[] haltCodes = loadHaltCodes();

		private static HALT_CODE[] loadHaltCodes()
		{
			string _jsonString;
			HALT_CODE_LIB.HaltCodes _haltCodes;
			HALT_CODE[] _out = null;

			try
			{
				_jsonString =
					HALT_CODE_LIB.HaltCodeJson;

				_haltCodes =
					JsonSerializer.Deserialize<HALT_CODE_LIB.HaltCodes>(
						json: _jsonString);

				_out =
					_haltCodes
						.HaltCodeCollection
						.Select(s => new HALT_CODE(s))
						.ToArray();

			}
			catch (Exception)
			{
				Debugger.Break();
			}

			return (_out == null) ? new HALT_CODE[] { } : _out;

		}

	}
}
