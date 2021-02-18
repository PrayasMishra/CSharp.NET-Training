public class Employee
{
	static int EmployeeId;
	static string EmployeeName;
	static string Addr;
	static string City;
	static string Dept;
	static double Salary;

	public void setName(string name)
	{
		EmployeeName = name;
	}

	public void setID(int id)
	{
		EmployeeId = id;
	}

	public void setCity(string c)
	{
		City = c;
	}

	public void setAddr(string address)
	{
		Addr = address;
	}
	
	public void setDept(string dep)
	{
		Dept = dep;
	}
	
	public void setSalary(double sal)
	{
		Salary = sal;
	}
	
	public double getSalary()
	{
		return Salary;
	}

}