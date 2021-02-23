using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CSharp.Day7
{
	class ErrorHandling
	{
		static void Main(string[] args)
		{
			int n1 = 0, res = 0;
			object obj;
			try
			{
				n1 = int.Parse(ReadLine());
				obj = "324hhh";
			}
			catch (Exception e)
			{
				WriteLine($"{e.Message}");
			}
			ReadKey();
		}
	}
}
