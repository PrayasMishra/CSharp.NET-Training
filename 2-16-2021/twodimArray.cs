using System;
using static System.Console;

class TwoDimArray
{
	static void Main()
	{
		int M = 5;
		int N = 6;
		int [,] arr = new int[M,N];
		WriteLine("enter array elements:\n---------------------------");
		for(var i=0; i<M; i++)
		{
			for(var j=0; j<N; j++)
			{
				WriteLine($"enter row {i}\n-------------");
				arr[i,j] = int.Parse(ReadLine());
			}
		}
		WriteLine("-----Printing array-----");
		for(var i=0; i<M; i++)
		{
			for(var j=0; j<N; j++)
			{
				Write($"{arr[i,j]}\t");
			}
		WriteLine();
		}
	}	
}