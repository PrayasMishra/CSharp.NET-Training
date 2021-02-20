using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Capgemini.CSharp.Day6
{
	enum Salutation {Mr=1, Mrs=2, Ms=3, Dr=4}; 
	class EnumEx
	{
		static void Main(string[] args)
		{
			Salutation title;
			WriteLine("enter name: ");
			string name = ReadLine();
			WriteLine("pick title (1-4)\nMr=1, Mrs=2, Ms=3, Dr=4");
			Enum.TryParse<Salutation>(ReadLine(),out title);
			/*
			int cho = int.Parse(ReadLine());

			switch (cho) 
			{
				case 1: title = Salutation.Mr.ToString();break;

				case 2: title = Salutation.Mrs.ToString();break;

				case 3: title = Salutation.Ms.ToString();break;

				case 4: title = Salutation.Dr.ToString();break;

				default: WriteLine("wrong choice....");break;
			}
			*/
			WriteLine($"Hiii {title}. {name}!");

			ReadKey();
		}
	}
}
