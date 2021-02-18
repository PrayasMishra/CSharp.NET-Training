using static System.Console;

using static System.Convert;

class parseMethod
{
	static void Main()
	{
		string name;
		char sex;
		double salary;

		WriteLine("enter name: ");
		name = ReadLine();
		WriteLine("enter sex: ");
		sex = char.Parse(ReadLine());
		WriteLine("enter salary: ");
		salary = double.Parse(ReadLine());

		WriteLine($"name: {name}\nsex = {sex}\nsalary: {salary}");
	}
}