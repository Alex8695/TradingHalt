using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingHaltLibrary.Model
{
	public partial class RSS
	{

		[System.SerializableAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
		[System.Xml.Serialization.XmlRootAttribute("rss", Namespace = "", IsNullable = false)]
		public class RssQuery
		{

			private RssChannel channelField;

			private decimal versionField;

			/// <remarks/>
			public RssChannel channel {
				get {
					return this.channelField;
				}
				set {
					this.channelField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.XmlAttributeAttribute()]
			public decimal version {
				get {
					return this.versionField;
				}
				set {
					this.versionField = value;
				}
			}
		}


	}
}
