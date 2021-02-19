using System;
using static System.Console;

class Bird
{
	public string Name;
	public double MaxHeight;

	public Bird()
	{
		this.Name = "";
		this.MaxHeight = 0.0d;
	}

	public Bird(string birdname, double max_ht)
	{
		this.Name = birdname;
		this.MaxHeight = max_ht;
	}

	public void fly()
	{
		WriteLine($"{this.Name} is flying at altitude {this.MaxHeight}");
	}
	
	public void fly(double AtHeight)
	{
		if(AtHeight <= this.MaxHeight)
			WriteLine($"this.Name flying at {AtHeight.ToString()}");
		else
			WriteLine($"{this.Name} cannot fly at this height");
	}

	static void Main()
	{
		Bird b = new Bird("Eagle",double.Parse("200"));
		b.fly();
		b.fly(double.Parse("300"));
	}
	
}