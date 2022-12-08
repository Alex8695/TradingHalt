using TradingHaltAPI;

namespace TradingHaltTEST
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Test_HaltCode()
		{
			Assert.IsNotEmpty(TradingHaltAPI.TradingHalt.HaltCodes);
			for (int i = 0; i < TradingHaltAPI.TradingHalt.HaltCodes.Length; i++)
			{
				Console.WriteLine(TradingHaltAPI.TradingHalt.HaltCodes[i].ToString());

			}
		}



		[Test]
		public void Test_Halt_Created_Today()
		{
			var _halts = TradingHaltAPI.TradingHalt.TradeHalts(
				TradingHaltAPI.Model.HaltType.CREATED_TODAY);

			Assert.IsNotEmpty(_halts);

			for (int i = 0; i < _halts.Length; i++)
			{
				Console.WriteLine(_halts[i].ToString());

			}
		}


		[Test]
		public void Test_Halt_Open_Today()
		{
			var _halts = TradingHaltAPI.TradingHalt.TradeHalts(
				TradingHaltAPI.Model.HaltType.RELEASED_TODAY);

			Assert.IsNotEmpty(_halts);

			for (int i = 0; i < _halts.Length; i++)
			{
				Console.WriteLine(_halts[i].ToString());

			}
		}



		[Test]
		public void Test_Halt_Monitor()
		{
			TradingHaltAPI.Model.TradeHalt[] _halts = new TradingHaltAPI.Model.TradeHalt[] { };

			TradingHaltAPI.TradingHaltMonitor.NewHalts += (object? sender, IEnumerable<TradingHaltAPI.Model.TradeHalt> e) => {
				_halts = e.ToArray();

				Console.WriteLine($"{DateTime.Now.ToString("hh:mm:ss.ffff")}: {_halts.Length} Halts Added");
			};

			TradingHaltAPI.TradingHaltMonitor.Init(halt_type:TradingHaltAPI.Model.HaltType.CREATED_TODAY);

			Task.Delay((int)TimeSpan.FromMinutes(2.1).TotalMilliseconds).Wait();


			Assert.IsNotEmpty(_halts);

			for (int i = 0; i < _halts.Length; i++)
			{
				Console.WriteLine(_halts[i].ToString());

			}
		}

		private void TradingHaltMonitor_NewHalts(object? sender, IEnumerable<TradingHaltAPI.Model.TradeHalt> e)
		{
			throw new NotImplementedException();
		}
	}
}