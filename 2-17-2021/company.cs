using System;
using static System.Console;
using static System.Convert;

class Corp
{
	public int EmpId; 
	public decimal Percentage, FoundationMarks, WebBasicMarks, DotNetMarks, TotalMarks, ObtainedMarks;
	public string Name;
	public static string CompanyName;
		
	public Corp()
	{
		this.EmpId = 0;
		this.Percentage = 0.0m;
		this.FoundationMarks = 0.0m;
		this.WebBasicMarks = 0.0m;
		this.DotNetMarks = 0.0m;
		this.TotalMarks = 0.0m;
		this.ObtainedMarks = 0.0m;
		this.Name = "";
		
	}

	static Corp()
	{
		CompanyName = "Corporate University";
	}

	public Corp(int Id, string N, decimal WebBscMarks, decimal DotNetMarks, decimal TMarks, decimal FoundMarks)
	{
		this.EmpId = Id;
		this.FoundationMarks = FoundMarks;
		this.WebBasicMarks = WebBscMarks;
		this.DotNetMarks = DotNetMarks;
		this.TotalMarks = TMarks;
		this.Name = N;
		
	}

	public void Display()
	{	
		WriteLine("-----------------------------------------------------------------");
		WriteLine($"EmpId: {EmpId}\nName: {Name}\nCompanyName: {CompanyName}\nWebBasicMarks: {WebBasicMarks}\nDotNetMarks: {DotNetMarks}\nFoundationMarks: {FoundationMarks}\nTotalMarks: {TotalMarks}");	
		WriteLine("-----------------------------------------------------------------");
	}
	
	
	static void Main()
	{
		Corp crp1 = new Corp();
		crp1.Display();

		Corp crp2;
		WriteLine("enter id: ");
		int Id = ToInt32(ReadLine());

		WriteLine("enter name: ");
		string N = ReadLine();

		WriteLine("enter marks in web basics: ");
		decimal WebBscMarks = ToDecimal(ReadLine());

		WriteLine("enter marks in .NET: ");
		decimal DotNetMarks = ToDecimal(ReadLine());

		WriteLine("enter marks in foundation courses: ");
		decimal FoundMarks = ToDecimal(ReadLine());

		decimal TMarks = 300;//given in question
		
		crp2 = new Corp(Id, N, WebBscMarks, DotNetMarks, TMarks, FoundMarks);
		crp2.Display();
	}
}