using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingHaltAPI.Model;
using TRADE_HALT = TradingHaltAPI.Model.TradeHalt;
using RSS_ITEMS = TradingHaltLibrary.Model.RSS.RssChannel;

namespace TradingHaltAPI.Control.RSS
{
	static class RSS_Conversion
	{
		public static DateTime ConvertDateTime(object time, object date)
		{
			DateTime _out = DateTime.MinValue;
			DateTime _dtTime;
			DateTime _dtDate;

			try
			{
				if (time.GetType()==typeof(DateTime))
				{
					if (date.GetType()==typeof(string))
					{
						_dtTime =
							(DateTime)time;

						if (DateTime.TryParse(
								s: time.ToString(),
								result: out _dtDate))
						{
							_out =
								_dtDate +
									_dtTime.TimeOfDay;
						}
					}
				}
			}
			catch (Exception)
			{
				//Debugger.Break();
			}
			return _out;
		}


		public static TRADE_HALT[] ConvertRSS(RSS_ITEMS rss)
		{
			TRADE_HALT[] _out;

			if ((rss == null) ? false : (rss.item==null)?false:rss.item.Length>0)
			{
				_out =
					rss.item.Select(s =>
						new TRADE_HALT(
							rss_item: s)
						).ToArray();
			}
			else
			{
				_out =
					new TRADE_HALT[] { };
			}

			return _out;
		}

	}
}
