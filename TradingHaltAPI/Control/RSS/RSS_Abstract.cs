using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using DATA = TradingHaltLibrary.Model.RSS.RssQuery;
using TRADE_HALT = TradingHaltAPI.Model.TradeHalt;

namespace TradingHaltAPI.Control.RSS
{
	partial class RSS_Query
	{
		public class RSS_Abstract
		{

			public DATA Data { get { return data; } }
			public TRADE_HALT[] TradeHalts { get => getTradeHalts(); }

			protected Uri uri { get; set; }

			HttpClient httpClient;
			HttpResponseMessage httpResponse;
			Stream stream;
			MemoryStream memoryStream;
			XmlSerializer xmlSerializer;
			DATA data;
			XmlReader xmlReader;

			private TRADE_HALT[] getTradeHalts() {

				TRADE_HALT[] _out = null;

				if (data!=null)
				{
					if (data.channel != null)
					{
						if ((data.channel.item==null)?false:data.channel.item.Length>0)
						{
							_out =
								 data.channel.item
								 .Select(s => new TRADE_HALT(s))
								 .ToArray();
						}
					} 
				}


				return (_out == null) ? new TRADE_HALT[] { } : _out;
			}

			private void readWithHttp()
			{


				try
				{
					Task.Run(async () => {


						using (httpClient = new HttpClient())
						{

							httpClient.DefaultRequestHeaders
								.Accept
								.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("text/xml"));

							httpResponse =
								await httpClient.GetAsync(
									requestUri: uri);

							xmlSerializer =
								new XmlSerializer(
									type: typeof(DATA));


							try
							{
								using (stream = await httpResponse.Content.ReadAsStreamAsync())
								{
									data =
										(DATA)xmlSerializer.Deserialize(stream: stream);
								}
							}
							catch (Exception)
							{
								Debugger.Break();
							}

						}

					}).Wait();

				}
				catch (Exception)
				{
					Debugger.Break();
				}

			}

			private void readWithXml()
			{
				try
				{
					xmlSerializer =
						new XmlSerializer(
							type: typeof(DATA));

					xmlReader =
						XmlReader.Create(
							inputUri: uri.AbsoluteUri);

					data =
						(DATA)xmlSerializer.Deserialize(xmlReader: xmlReader);
				}
				catch (Exception)
				{
					Debugger.Break();
				}


			}

			private void run()
			{

				readWithXml();

			}

			public void Run()
			{
				run();
			}

			protected RSS_Abstract()
			{
			}


		}
	}
	
}
