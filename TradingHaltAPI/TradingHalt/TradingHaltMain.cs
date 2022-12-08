using System.Diagnostics;
using TRADE_HALT = TradingHaltAPI.Model.TradeHalt;

namespace TradingHaltAPI
{
    public partial class TradingHalt
	{

        public static TRADE_HALT[] TradeHalts(Model.HaltType halt_type) {

            TRADE_HALT[] _out = null;

			Control.RSS.RSS_Query.RSS_Current _queryCurrent;
			Control.RSS.RSS_Query.RSS_OpenToday _queryOpenToday;

			try
			{
                switch (halt_type)
                {
                    case Model.HaltType.RELEASED_TODAY:

                        _queryOpenToday =
                            new Control.RSS.RSS_Query.RSS_OpenToday();

                        _queryOpenToday.Run();

                        _out =
                            _queryOpenToday.TradeHalts
                            .ToArray();
						

						break;
                    case Model.HaltType.CREATED_TODAY:
                    default:

						_queryCurrent =
							new Control.RSS.RSS_Query.RSS_Current();

						_queryCurrent.Run();

                        _out =
                            _queryCurrent.TradeHalts
                            .ToArray();

						break;
                }
			}
            catch (Exception)
            {
                Debugger.Break();
            }

            return (_out == null) ? new TRADE_HALT[] { } : _out;
        
        }
                       
    }
}