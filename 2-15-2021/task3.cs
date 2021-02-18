using static System.Console;
using static System.Convert;

class Employee
{
	string name;
	decimal salary;

	public void DisplayEmployee()
        {
           WriteLine($"name of employee: {name}\nsalary of employee: {salary}\n-------------------------"); 
        }

	public void GetEmployeeData()
        {
                WriteLine("Enter name of employee: ");
                name = ReadLine();
                WriteLine("Enter salary of employee: ");
                salary =decimal.Parse(ReadLine());     
	}
   
        static void Main()
        {
		WriteLine("how many employees??...");
		int size = int.Parse(ReadLine());
		Employee[] emp = new Employee[size];	
		for(int i = 0; i < size; i++)
            	{
                	WriteLine($"Enter the data of employee with id: {i+1} ");
                	emp[i] = new Employee();
                	emp[i].GetEmployeeData();
		}
		
		WriteLine("Display data:\n-----------------------------------------");

		for(int i = 0; i < size; i++)
            	{
                	emp[i].DisplayEmployee();
            	}
        }
}