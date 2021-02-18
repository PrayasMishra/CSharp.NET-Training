using static System.Console;

class ArrayEx
{
	static void Main()
	{
		WriteLine("enter size of array: ");
		int size = int.Parse(ReadLine());
		double [] salary = new double[size];
		
		for(int a=0; a.salary.length; a++)
		{
			WriteLine("enter salary: ");	
			salary[a] = double.Parse(ReadLine());
		}
		WriteLine("salaries: ");	
		for(int a=0; a.salary.length; a++)
		{
			WriteLine($"{salary[a]}");	
		}
	}
}