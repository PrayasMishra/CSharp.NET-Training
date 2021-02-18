using static System.Console;
class ExecuteClass
{
	static void Main()
	{
		int num1 = 10, num2 = 20;
		AddClass add = new AddClass();
		int res_add = add.add(num1,num2);
		WriteLine($"Add Result = {res_add}");

		MultClass m = new MultClass();
		int res_mul = m.mult(num1,num2);
		WriteLine($"mul result = {res_mul}");
	}

}