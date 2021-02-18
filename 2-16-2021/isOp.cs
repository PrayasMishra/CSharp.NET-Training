using static System.Console;

class Employee
{
	public string Name;	//member variables
	
	public Employee(string name)
	{
		this.Name = name;
	}	
}

class ExecuteClass
{
	static void Main()
	{
		Employee e1 = new Employee("Prayas");
		object [] items = {"hello",null,121,450.4m,new Employee("kusha"),false};
		
		foreach(var it in items)
		{
			if(it is "hello")
			{
				WriteLine("constant pattern matching");
			}
			if(it is null)
			{
				WriteLine("constant pattern matching - null");
			}
			if(it is Employee e)
			{
				WriteLine($"type pattern matching\tName: {e?.GetType().Name}");
			}
			if(it is int i)
			{
				WriteLine($"type pattern matching: {i}");
			}
		}
	}
}