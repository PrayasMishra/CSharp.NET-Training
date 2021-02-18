using static System.Console;

class Array2
{
	static void Main()
	{
		WriteLine("enter array dimensions: ");
		int dim1 = int.Parse(ReadLine());
		int dim2 = int.Parse(ReadLine());
		int [,] arr = new int[dim1,dim2];

		for(int i=0; i<arr.GetLength(0); i++)
		{
			WriteLine($"row no: {i+1}");
			for(int j=0; j<arr.GetLength(1); j++)
			{
				arr[i,j] = int.Parse(ReadLine());
			}
		}
		WriteLine("-----------------display array---------------");
		for(int i=0; i<arr.GetLength(0); i++)
		{
			//WriteLine($"row no: {i+1}");
			for(int j=0; j<arr.GetLength(1); j++)
			{
				Write($"{arr[i,j]}  ");
			}
		WriteLine();
		}
	}	
}