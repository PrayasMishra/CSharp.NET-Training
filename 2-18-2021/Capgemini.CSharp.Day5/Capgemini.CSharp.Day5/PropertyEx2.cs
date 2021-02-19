using System;
using static System.Console;

namespace Capgemini.CSharp.Day5
{
	class PropertyEx2
	{
		public int StudId{ get; set; }

		public string StudentName { get; set; }

	}

	class ExecuteClass2
	{
		static void Main(string[] args)
		{
			PropertyEx2 pex2 = new PropertyEx2();
			WriteLine("enter student id: ");
			pex2.StudId = int.Parse(ReadLine());

			WriteLine("enter student name: ");
			pex2.StudentName = ReadLine();

			WriteLine($"student id: {pex2.StudId}\nstudent name: {pex2.StudentName}");
			ReadKey();
		}
	}
}
