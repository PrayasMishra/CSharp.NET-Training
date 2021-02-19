using System;
using static System.Console;

namespace Capgemini.CSharp.Day5
{
	class Employee
	{
		protected int EmployeeId { get; set; }
		protected string EmployeeName { get; set; }
		protected double Salary { get; set; }

		public Employee GetEmployeeDetails(int empId, string name, double salary)
		{
			Employee tmp = new Employee
			{
				EmployeeId = empId,
				EmployeeName = name,
				Salary = salary
			};
			return tmp;
		}

		public void PrintEmployeeDetails(Employee e)
		{
			WriteLine($"EmployeeId: {e.EmployeeId}\nEmployeeName: {e.EmployeeName}\nSalary: {e.Salary}");
		}

	}

	class Manager : Employee
	{
		public string ProjectName { get; set; }

		public Manager GetEmployeeDetails(string projectName)
		{
			Manager man = new Manager { ProjectName = projectName };
			return man;
		}

		public void PrintManagerDetails(Manager m)
		{
			WriteLine($"Project name: {m.ProjectName}");
		}
	}

	class ExecuteEmployee
	{
		static void Main(string[] args)
		{
			Employee obj = new Employee();
			Employee e1 = obj.GetEmployeeDetails(101, "Prayas", 90000.00d);
			obj.PrintEmployeeDetails(e1);

			Manager man = new Manager();
			Employee e2 = man.GetEmployeeDetails(102,"Arjun",450000.00d);
			Manager m = man.GetEmployeeDetails("Project Dynamo");

			man.PrintEmployeeDetails(e2);
			man.PrintManagerDetails(m);

			ReadKey();
		}
	}


}
