using static System.Console;
using System;

class BooksDemo
{
	string [] ColName = {"Title","Author","Publisher","Price"};
	string [,] BookDetails = new string[2,4];
	
	public void SetBooks()
	{
		for(var x=0; x<2; x++)
		{
			WriteLine($"enter book{x}");
			for(var y=0; y<4; y++)
			{
				WriteLine($"enter {ColName[y]}");
				this.BookDetails[x,y] = ReadLine();
			}
		}
	}

	public void DisplayBooks()
	{
		foreach(var i in ColName)
		{
			Write($"{i}				");
		}
		WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
		
		for(var x=0; x<2; x++)
		{
			for(var y=0; y<4; y++)
			{
				Write($"{BookDetails[x,y]}				");
			}
			WriteLine();
		}
	}
	
	static void Main()
	{
		BooksDemo bd = new BooksDemo();
		bd.SetBooks();
		bd.DisplayBooks();	
	}
}