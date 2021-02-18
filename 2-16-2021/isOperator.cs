using static System.Console;
using System;

class Square
{
	public double Area(double a)
	{
		return a*a;
	}
}

class Circle
{
	public double Area(double a)
	{
		return Math.PI * a * a;
	}
}

class ExecuteClass
{
	public static void FindArea(object obj)
	{
		Write("Enter a Number :");
		double x=double.Parse(ReadLine());
				
		if(obj is Square)
		{
			Square s1=(Square)obj;
			WriteLine($"Area :{s1.Area(x)}");
		}
		if(obj is Circle)
		{
			Circle c1=(Circle)obj;
			WriteLine($"Area :{c1.Area(x)}");
		}
		else if(obj is string)
		{
			WriteLine(obj);
		}
		else
		{
			WriteLine("Neither Circle nor Square");
		}
						
	}

	static void Main()
	{
		Square s1=new Square();
		Circle c1=new  Circle();
		//ExecuteClass ex=new ExecuteClass();
		ExecuteClass.FindArea(s1);
		ExecuteClass.FindArea(c1);
	}
}
