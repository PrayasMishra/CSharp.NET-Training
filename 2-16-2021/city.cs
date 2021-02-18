using System;
using static System.Console;

class City
{
	static void Main()
	{
		string [] cities = new string[5];
		WriteLine("enter city name: ");
		for(var i=0; i<5; i++)
		{
			cities[i] = ReadLine();
		}
	
		WriteLine("cites entered are: \n--------------------------");
		
		foreach(var i in cities)
		{
			WriteLine(i);
		}
	}
}