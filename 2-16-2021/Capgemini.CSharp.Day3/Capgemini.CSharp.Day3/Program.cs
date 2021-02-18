using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CSharp.Day3
{
	class Program
	{
		static void Main(string[] args)
		{
			WriteLine("enter name: ");
			string name = ReadLine();
			WriteLine("enter password: ");
			string pwd = ReadLine();

			WriteLine($"name: {name}\tpassword: {pwd}");
			ReadKey();
		}
	}
}
