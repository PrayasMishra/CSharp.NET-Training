using static System.Console;
using System;
using static System.Convert;

class Calculator
{
	static void Main()
	{
		ArithmeticOps aops = new ArithmeticOps();
		WriteLine("------MENU------\nchoose(option in UPPERCASE ONLY):");
		WriteLine("A.Add\nB.Subtract\nC.Multiply\nD.Divide\nE.Modulo operation");
		char ch = char.Parse(ReadLine());
		bool flag = true;
		
		WriteLine("enter num1: ");
		int a = int.Parse(ReadLine());
		WriteLine("enter num2: ");
		int b = int.Parse(ReadLine());
		decimal res = 0.0m;
		while(flag)
		{
			switch(ch)
			{
				case 'A': res = aops.Add(a,b);break;
			
				case 'B': res = aops.Subtract(a,b);break;
		
				case 'C': res = aops.Multiply(a,b);break;

				case 'D': res = aops.Divide(a,b);break;

				case 'E': res = aops.Modulo(a,b);break;

				default:  WriteLine("This Action Is Not Available");break;
			}

			WriteLine($"Result = {res}");
			WriteLine("continue (yes=1/no=0)?");
			flag = ToBoolean(ToInt32(ReadLine()));
			
			if(flag)
			{
				WriteLine("------MENU------\nchoose(option in UPPERCASE ONLY):");
				WriteLine("A.Add\nB.Subtract\nC.Multiply\nD.Divide\nE.Modulo operation");
				ch = char.Parse(ReadLine());
				
				WriteLine("enter num1: ");
				a = int.Parse(ReadLine());
				WriteLine("enter num2: ");
				b = int.Parse(ReadLine());
			}
			else
			{
				WriteLine("BYE.");
				break;
			}	
		}
		
	}
}