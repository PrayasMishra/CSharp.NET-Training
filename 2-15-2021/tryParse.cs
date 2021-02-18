using static System.Console;

class TryParseExample
{
	static void Main()
	{
		int x;
		WriteLine("enter a num:");
		int.TryParse(ReadLine(),out x);
		WriteLine($"value of x: {x}");
	}	
}