using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSS_URI = TradingHaltLibrary.Model.URI;

namespace TradingHaltAPI.Control.RSS
{
	partial class RSS_Query
	{
		public class RSS_Current:RSS_Abstract
		{

			public RSS_Current()
			{
				this.uri =
					RSS_URI.UriHaltCurrent;
			}
		}

	}
}
