using static System.Console;

class ExecuteEmpDLL
{
	static void Main()
	{
		Employee e1 = new Employee();
		e1.setName("prayas");
		e1.setID(121);
		e1.setCity("bbsr");
		e1.setAddr("near KFC");
		e1.setDept("tech");
		e1.setSalary(50000.00d);
		double emp_sal = e1.getSalary();
		WriteLine($"salary = {emp_sal}");
	}
}