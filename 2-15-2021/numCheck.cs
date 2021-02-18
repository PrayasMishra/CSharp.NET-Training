using static System.Console;
using System;

class NumCheck
{
	static void Main()
	{
		WriteLine("enter a number...");
		int x = int.Parse(ReadLine());
		
		switch(x)
		{	
			case 1: WriteLine($"{x} is in 1,2,3,4,5");break;

			case 2: WriteLine($"{x} is in 1,2,3,4,5");break;

			case 3: WriteLine($"{x} is in 1,2,3,4,5");break;

			case 4: WriteLine($"{x} is in 1,2,3,4,5");break;

			case 5: WriteLine($"{x} is in 1,2,3,4,5");break;
			
			default: WriteLine($"ERROR! {x} not in 1,2,3,4,5");break;
		}
	}
}