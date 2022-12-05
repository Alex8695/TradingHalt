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
		[System.Xml.Serialization.XmlRootAttribute("rssChannelItem", Namespace = "", IsNullable = false)]

		public class RssChannelItem
		{

			private string titleField;

			private string pubDateField;

			private string haltDateField;

			private System.DateTime haltTimeField;

			private string issueSymbolField;

			private string issueNameField;

			private string marketField;

			private string reasonCodeField;

			private object pauseThresholdPriceField;

			private object resumptionDateField;

			private object resumptionQuoteTimeField;

			private object resumptionTradeTimeField;

			private string descriptionField;

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
			public string pubDate {
				get {
					return this.pubDateField;
				}
				set {
					this.pubDateField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.nasdaqtrader.com/")]
			public string HaltDate {
				get {
					return this.haltDateField;
				}
				set {
					this.haltDateField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.nasdaqtrader.com/", DataType = "time")]
			public System.DateTime HaltTime {
				get {
					return this.haltTimeField;
				}
				set {
					this.haltTimeField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.nasdaqtrader.com/")]
			public string IssueSymbol {
				get {
					return this.issueSymbolField;
				}
				set {
					this.issueSymbolField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.nasdaqtrader.com/")]
			public string IssueName {
				get {
					return this.issueNameField;
				}
				set {
					this.issueNameField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.nasdaqtrader.com/")]
			public string Market {
				get {
					return this.marketField;
				}
				set {
					this.marketField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.nasdaqtrader.com/")]
			public string ReasonCode {
				get {
					return this.reasonCodeField;
				}
				set {
					this.reasonCodeField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.nasdaqtrader.com/")]
			public object PauseThresholdPrice {
				get {
					return this.pauseThresholdPriceField;
				}
				set {
					this.pauseThresholdPriceField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.nasdaqtrader.com/")]
			public object ResumptionDate {
				get {
					return this.resumptionDateField;
				}
				set {
					this.resumptionDateField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.nasdaqtrader.com/")]
			public object ResumptionQuoteTime {
				get {
					return this.resumptionQuoteTimeField;
				}
				set {
					this.resumptionQuoteTimeField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.nasdaqtrader.com/")]
			public object ResumptionTradeTime {
				get {
					return this.resumptionTradeTimeField;
				}
				set {
					this.resumptionTradeTimeField = value;
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

		}
	}
}
