using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TRADE_HALT = TradingHaltAPI.Model.TradeHalt;


namespace TradingHaltAPI.Control
{
	class TradeHaltComparer : IEqualityComparer<TRADE_HALT>
	{
		private static readonly PropertyInfo[] props = typeof(TRADE_HALT).GetProperties();


		public bool Equals(TRADE_HALT? x, TRADE_HALT? y)
		{
			bool _out = true;

			if (x==null || y==null)
			{
				_out = false;
			}

			for (int i = 0; i < props.Length; i++)
			{
				if (props[i].GetValue(x) != props[i].GetValue(y))
				{
					_out = false;
					i += props.Length;
				}
			}



			Debug.WriteLine(
				$"{_out.ToString().PadLeft(5)}:"
				+$"{x.Symbol} {x.ReasonCode} {x.TimeStampStart.ToString()} {x.TimeStampQuote.ToString()} {x.TimeStampResume.ToString()}"
				
				);
			return _out;
		}

		public int GetHashCode([DisallowNull] TRADE_HALT obj)
		{
			throw new NotImplementedException();
		}
	}
}
