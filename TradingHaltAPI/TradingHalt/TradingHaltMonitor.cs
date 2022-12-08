using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TRADE_HALT = TradingHaltAPI.Model.TradeHalt;
using TIMER = System.Timers.Timer;
using TradingHaltAPI.Control;

namespace TradingHaltAPI
{
	public static class TradingHaltMonitor
	{
		public static event EventHandler<IEnumerable<TRADE_HALT>> NewHalts;


		private static TRADE_HALT[] tradingHalts;
		private static Model.HaltType haltType;
		private static readonly TIMER timer = new TIMER();


		private static void onNewHalts(TRADE_HALT[] e)
		{
			EventHandler<IEnumerable<TRADE_HALT>> _handler;

			_handler =
				NewHalts;

			if (_handler != null)
			{
				_handler(typeof(TradingHaltMonitor), e);
			}
		}


		private static void onTimer(object? sender, System.Timers.ElapsedEventArgs e)
		{
			TRADE_HALT[] _halts;
			TRADE_HALT[] _new;
			timer.Stop();

			TradeHaltComparer _comparer;

			_comparer =
				new TradeHaltComparer();

			_halts =
				TradingHaltAPI.TradingHalt.TradeHalts(
					halt_type: haltType);

			if (tradingHalts == null)
			{
				_new =
					_halts
					.ToArray();
			}
			else
			{
				_new =
					_halts
					.Where(w => tradingHalts.All(a => w.Equals(a)==false))
					.ToArray();
			}



			tradingHalts =	 
				_halts.ToArray();

			if (_new.Length > 0)
			{
				onNewHalts(_new);
			}





			timer.Interval =
				TradingHaltLibrary.Model.Parameter.RefreshInterval.TotalMilliseconds;

			timer.Start();
		}



		public static void Init(Model.HaltType halt_type)
		{
			haltType =
				halt_type;

			timer.Elapsed += onTimer;
			timer.AutoReset = true;
			timer.Interval = 1000;

			timer.Start();

		}

	}
}
