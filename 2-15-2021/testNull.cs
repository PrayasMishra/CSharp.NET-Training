using static System.Console;
using System;
class Test
{
	int? id;
	string? name;
	DateTime StartDate;
	DateTime EstEndDate;
	Nullable<DateTime> ActEndDate;
	
	static void Main()
	{
		Test t1 = new Test();
		t1.StartDate = DateTime.Now;
		t1.EstEndDate = DateTime.Now.AddDays(3);
		t1.ActEndDate = null;
		
		if(t1.id.HasValue)
		{
			WriteLine($"name: {t1.name}\nid: {t1.id}");
		}
		else
		{
			WriteLine("id not assigned");
		}
		WriteLine($"start date: {t1.StartDate}\nest end date: {t1.EstEndDate}");	
		
		if(t1.ActEndDate is null)
		{
			WriteLine("actual end date will be announced later...");
		}
		else
		{
			WriteLine($"Actual end date: {t1.ActEndDate}");
		}
	}
}