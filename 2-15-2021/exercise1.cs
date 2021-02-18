using static System.Console;
using static System.Convert;

class StudentInfo
{
	int id;
	string name;
	int age;
	char gender;
	long mobileno;
	decimal totalMark;

	public void GetStudentInfo()
	{
		WriteLine("enter name:");
		this.name = ReadLine();

		WriteLine("enter ID:");
		this.id = int.Parse(ReadLine());

		WriteLine("enter age:");
		this.age = int.Parse(ReadLine());

		WriteLine("enter gender:");
		this.gender = char.Parse(ReadLine());

		WriteLine("enter mobileno:");
		this.mobileno = ToInt64(ReadLine());

		WriteLine("enter totalmark:");
		this.totalMark = decimal.Parse(ReadLine());
	}

	public void PrintStudentInfo()
	{
		WriteLine("---------------------------------------------------------------------------------");
		WriteLine($"name: {name}\nid: {id}\nage: {age}\ngender: {gender}");
		WriteLine($"mobileno: {mobileno}\ntotalmarks = {totalMark}");
		WriteLine("---------------------------------------------------------------------------------");
	}

	static void Main()
	{
		StudentInfo si = new StudentInfo();
		si.GetStudentInfo();
		si.PrintStudentInfo();
	}
}
