using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSS_ITEM = TradingHaltLibrary.Model.RSS.RssChannelItem;
using RSS_CONVERT = TradingHaltAPI.Control.RSS.RSS_Conversion;
using System.Diagnostics;

namespace TradingHaltAPI.Model
{
	[DebuggerDisplay("{Symbol} - {ReasonCode}")]
	public class TradeHalt
	{
		public string Symbol { get => symbol; set => symbol = value; }
		public string SymbolFull { get => symbolFull; set => symbolFull = value; }
		public string Market { get => market; set => market = value; }
		public string ReasonCode { get => reasonCode; set => reasonCode = value; }
		public double ResumePrice { get => pauseThreasholdPrice; set => pauseThreasholdPrice = value; }
		public DateTime TimeStampStart { get => timestampStart; set => timestampStart = value; }
		public DateTime TimeStampQuote { get => timestampQuote; set => timestampQuote = value; }
		public DateTime TimeStampResume { get => timestampResume; set => timestampResume = value; }

		private string symbol;
		private string symbolFull;
		private string market;
		private string reasonCode;
		private double pauseThreasholdPrice;
		private DateTime timestampStart;
		private DateTime timestampQuote;
		private DateTime timestampResume;

		public TradeHalt()
		{
		}

		internal TradeHalt(RSS_ITEM rss_item)
		{
			this.symbol = rss_item.IssueSymbol;
			this.symbolFull = rss_item.IssueName;
			this.market = rss_item.Market;
			this.reasonCode = rss_item.ReasonCode;

			if (rss_item.PauseThresholdPrice != null)
			{
				double.TryParse(
					s: rss_item.PauseThresholdPrice.ToString(),
					result: out this.pauseThreasholdPrice);
			}

			this.timestampStart =
				RSS_CONVERT.ConvertDateTime(
					time: rss_item.HaltTime,
					date: rss_item.HaltDate);

			if (rss_item.ResumptionDate != null)
			{
				this.timestampQuote =
					RSS_CONVERT.ConvertDateTime(
						time: rss_item.ResumptionQuoteTime,
						date: rss_item.ResumptionDate);

				this.timestampResume =
					RSS_CONVERT.ConvertDateTime(
						time: rss_item.ResumptionTradeTime,
						date: rss_item.ResumptionDate);

			}
		}

		public override string ToString()
		{
			return $"{symbol}-> "
				+$"Code: {reasonCode} "
				+$"Issued: {TimeStampStart.ToString("M/d/yy hh:mm:ss")}"
				+ $"Quote: {TimeStampQuote.ToString("M/d/yy hh:mm:ss")}"
				+ $"Resume: {timestampResume.ToString("M/d/yy hh:mm:ss")}";
		}

		public override bool Equals(object? obj)
		{
			bool _out = false;
			TradeHalt _th;
			int _i = 0;

			if (obj != null) {

				if (obj.GetType() == typeof(TradeHalt))
				{
					_th =
						(TradeHalt)obj;

					_i = _i|((_th.Symbol == this.Symbol) ? 0 : 1);

					_i = _i | ((_th.Market == this.Market) ? 0 : 2);

					_i = _i | ((_th.ReasonCode == this.ReasonCode) ? 0 : 4);

					_i = _i | ((_th.ResumePrice == this.ResumePrice) ? 0 : 8);

					_i = _i | ((_th.TimeStampStart == this.TimeStampStart) ? 0 : 16);

					_i = _i | ((_th.TimeStampQuote == this.TimeStampQuote) ? 0 : 32);

					_i = _i | ((_th.TimeStampResume == this.TimeStampResume) ? 0 : 64);


					_out = 
						_i == 0;

					//Debug.Print($"{((_out)?"1":"0")} - {Convert.ToString(_i,2).PadLeft(8,'0')}");
				}
			}



			return _out;
		}
	}
}
