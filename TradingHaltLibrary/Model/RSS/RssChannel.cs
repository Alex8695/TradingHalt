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
		[System.Xml.Serialization.XmlRootAttribute("rssChannel", Namespace = "", IsNullable = false)]

		public class RssChannel
		{

			private string titleField;

			private string linkField;

			private string descriptionField;

			private string copyrightField;

			private string pubDateField;

			private byte ttlField;

			private byte numItemsField;

			private RssChannelItem[] itemField;

			/// <remarks/>
			public string title {
				get {
					return this.titleField;
				}
				set {
					this.titleField = value;
				}
			}

			/// <remarks/>
			public string link {
				get {
					return this.linkField;
				}
				set {
					this.linkField = value;
				}
			}

			/// <remarks/>
			public string description {
				get {
					return this.descriptionField;
				}
				set {
					this.descriptionField = value;
				}
			}

			/// <remarks/>
			public string copyright {
				get {
					return this.copyrightField;
				}
				set {
					this.copyrightField = value;
				}
			}

			/// <remarks/>
			public string pubDate {
				get {
					return this.pubDateField;
				}
				set {
					this.pubDateField = value;
				}
			}

			/// <remarks/>
			public byte ttl {
				get {
					return this.ttlField;
				}
				set {
					this.ttlField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.nasdaqtrader.com/")]
			public byte numItems {
				get {
					return this.numItemsField;
				}
				set {
					this.numItemsField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.XmlElementAttribute("item")]
			public RssChannelItem[] item {
				get {
					return this.itemField;
				}
				set {
					this.itemField = value;
				}
			}
		}

	}
}
