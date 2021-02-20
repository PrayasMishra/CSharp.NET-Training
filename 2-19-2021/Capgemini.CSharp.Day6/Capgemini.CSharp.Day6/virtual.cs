using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CSharp.Day6
{
	class Parent
	{
		public void Print()
		{
			Console.WriteLine("parent class print method");
		}
	}

	class ChildA : Parent
	{
        public void Print() => Console.WriteLine("child A class print method");
    }

	class ExecuteVirtual
	{
		static void Main(string[] args)
		{
			ChildA ChA = new ChildA();
			ChA.Print();
			Console.ReadKey();
		}
	}
}
