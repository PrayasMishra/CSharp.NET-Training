using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Capgemini.CSharp.Day5
{
	class Supplier
	{
		int SupplierId { get; set; }
		string SupplierName { get; set; }
		string City { get; set; }
		string PhoneNo { get; set; }
		string Email { get; set; }

		public Supplier AcceptDetails(int Id,string Name,string PhoneNo,string City,string Email)
		{
			return new Supplier {
				SupplierId = Id,
				SupplierName = Name,
				City = City,
				PhoneNo = PhoneNo,
				Email = Email
			};
		}

		public void DisplayDetails(Supplier s)
		{
			WriteLine("-------------------Display-Supplier-Data-----------------------");
			WriteLine($"SupplierId: {s.SupplierId}\nSupplierName: {s.SupplierName}\nPhone: {s.PhoneNo}\nCity: {s.City}\nEmail: {s.Email}");
		}

	}

	class SupplierTest
	{
        static void Main(string[] args)
        {
			WriteLine("enter id: ");
			int Id = int.Parse(ReadLine());
			WriteLine("enter name: ");
			string Name = ReadLine();
			WriteLine("enter phone number: ");
			string PhoneNo = ReadLine();
			WriteLine("enter city: ");
			string City = ReadLine();
			WriteLine("enter email: ");
			string Email = ReadLine();

			Supplier sup = new Supplier().AcceptDetails(Id,Name,PhoneNo,City,Email);
			new Supplier().DisplayDetails(sup);

			ReadLine();
		}
	}
}
