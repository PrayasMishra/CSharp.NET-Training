using static System.Console;
class Unboxing
{
	static void Main()
	{
		int n1 = 10;
		object ob = n1;
		WriteLine($"Boxed value: {ob}");
		
		//type casting
		int res = (int)ob;
		WriteLine($"Unboxed value: {res}");
		
		decimal d1 = 500.45m;
		int n2 = (int)d1;
		WriteLine($"decimal to int: {n2}");

	}	
}