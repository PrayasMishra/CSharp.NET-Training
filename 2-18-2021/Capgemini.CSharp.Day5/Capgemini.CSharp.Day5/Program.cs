using System;
using static System.Console;
using static System.Convert;

namespace Capgemini.CSharp.Day5
{
	class PropertyExample
	{
		private string _UserId;
		double _Price;
		string _Pwd;
		string _City;
		int _CodeNo;

		public string UserId
		{
			get
			{
				return _UserId;
			}
			set
			{
				_UserId = value;
			}
		}
		public double Price
		{
			get
			{
				return _Price;
			}

			set
			{
				if(value>0 && value <= 10000)
                {
					_Price = value;
				}
			}
		}

		public string Pwd
		{
			get {
				return _Pwd;
			}

			set {
				_Pwd = value;
			}
		}

		public string City
		{
			get {
				return _City;
			}

			set {
				_City = value;
			}
		}

		public int CodeNo
        {
			get
			{
				return _CodeNo;
			}

			set {
				_CodeNo = value;
			}
        }

		static void Main(string[] args)
		{
			PropertyExample obj = new PropertyExample();
			WriteLine("Enter the User Id:");
			obj.UserId = ReadLine();

			WriteLine("Enter the Price:");
			obj.Price = double.Parse(ReadLine());

			WriteLine("Enter the Pwd:");
			obj.Pwd = ReadLine();

			WriteLine("Details:\n-------------------------");
			WriteLine($"User Id: {obj.UserId}\nprice: {obj.Price}\npassword: {obj.Pwd}");

			ReadKey();
		}
	}
}