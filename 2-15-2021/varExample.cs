using static System.Console;

class VarExample
{
	static void Main()
	{
		int c = 10;
		var x = 10;
		var obj = new VarExample();
		var fl = 100.5f;
		c = 500;
		WriteLine($"value of c: {c}");
		//c = "hello";
	}
}