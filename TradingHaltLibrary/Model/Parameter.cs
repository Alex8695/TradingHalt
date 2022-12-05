using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingHaltLibrary.Model
{
	public static class Parameter
	{
		/// <summary>
		/// <c>RefreshInterval</c>
		/// <para>Minimum Time Required Between RSS Update</para>
		/// </summary>
		public static TimeSpan RefreshInterval { get { return refreshTimeSpan; } }
		private static readonly TimeSpan refreshTimeSpan = TimeSpan.FromMinutes(1);
	}
}
