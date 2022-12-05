using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingHaltLibrary.Model
{
	public static class URI
	{
		/// <summary>
		/// <c>UriHaltCurrent</c>
		/// <para>
		/// Returns Only Securities Where The Halt Started Today
		/// </para>
		/// <para>
		/// <seealso href="https://www.nasdaqtrader.com/Trader.aspx?id=TradeHaltRSS">
		/// Nasdaq Halt RSS Info
		/// </seealso>
		/// </para>
		/// </summary>
		public static Uri UriHaltCurrent { get { return uriHaltCurrent; } }
		static readonly Uri uriHaltCurrent = new Uri($@"http://www.nasdaqtrader.com/rss.aspx?feed=tradehalts");


		/// <summary>
		/// <c>UriHaltLiftToday</c>
		/// <para>
		/// Returns Only Securities Where The Halt Ends Today
		/// </para>
		/// <para>
		/// <seealso href="https://www.nasdaqtrader.com/Trader.aspx?id=TradeHaltRSS">
		/// Nasdaq Halt RSS Info
		/// </seealso>
		/// </para>
		/// </summary>
		public static Uri UriHaltLiftToday { 
			get { 
				return new Uri(
					$"http://www.nasdaqtrader.com/rss.aspx?feed=tradehalts&resumedate={DateTime.Now.ToString("mmddyyyy")}"); 
			} 
		}
	
	}
}
