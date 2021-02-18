using static System.Console;
using static System.Convert;

class Convertion
{
	static void Main()
	{
		string name;
		double salary;
		WriteLine("enter name: ");
		name = ReadLine();
		WriteLine("enter salary: ");
		salary = ToDouble(true);

		WriteLine($"name: {name}\tsalary: {salary}");
	}	
}