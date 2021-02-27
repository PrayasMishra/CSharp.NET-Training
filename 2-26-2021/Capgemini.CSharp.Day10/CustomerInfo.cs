using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Capgemini.CSharp.Day10
{
	[Serializable]
	public class CustomerInfo
	{
		public int Id { get; set; }
		public string FirstName { get; set;}
		public string LastName { get; set; }
		
		[NonSerialized]		//can be applied only on variable , not on properties.
		private string MobileNo;

		public void Binary_Serilization(CustomerInfo customer, string path)
		{
			//FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
			FileStream fs = File.Create(path);
			BinaryFormatter formatter = new BinaryFormatter();
			formatter.Serialize(fs, customer);
			fs.Close();
		}

		public CustomerInfo Binary_Deserialization(string path)
		{
			FileStream fs = File.OpenRead(path);
			BinaryFormatter formatter = new BinaryFormatter();
			var customer = formatter.Deserialize(fs) as CustomerInfo;
			fs.Close();
			return customer;
		}

        static void Main(string[] args)
        {
			string path = @"D:\Capgemini docs\Module1\files\CustomerInfo.dat";
			CustomerInfo cus = new CustomerInfo()
			{
				Id = int.Parse(ReadLine()),
				FirstName = ReadLine(),
				LastName = ReadLine(),
                MobileNo = ReadLine()
			};

			cus.Binary_Serilization(cus,path);
			var info = cus.Binary_Deserialization(path);
			WriteLine($"id: {info.Id}\nfirstname: {info.FirstName}\nlastname: {info.LastName}\n{info.MobileNo}");
			
			ReadLine();
        }
	}
}
