using static System.Console;
class DynamicExample
{	
	static void Main()
	{
		int x = 10;
		dynamic d = 10;//runtime
		WriteLine($"d = {d}");
		d = "hello";
		WriteLine($"d = {d}");
		d = true;
		WriteLine($"d = {d}");
	}	
}