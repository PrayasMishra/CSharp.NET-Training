using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CSharp.Day6
{
	public static class ExtensionCreditCard
	{
		public static string PrintCardNo(this string cardNo)
		{
			return string.Concat(cardNo.Split('-'));
		}
	}
}
