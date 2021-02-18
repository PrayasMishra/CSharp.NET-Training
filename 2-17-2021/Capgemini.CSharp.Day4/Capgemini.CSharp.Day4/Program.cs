using System;
using static System.Console;
using static System.Convert;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CSharp.Day4
{
	class ProductDemo
	{
		object ProductId, ProductName, Price, Quantity;
		double AmountPayable;
        static void Main(string[] args)
		{
            ProductDemo pd = new ProductDemo();
			pd.GetDetails();
			pd.ShowDetails();
			ReadKey();
		}

        private void ShowDetails()
        {
			double price = ToDouble(this.Price);
			int quant = ToInt32(this.Quantity);

			WriteLine($"Product ID: {ToInt32(this.ProductId)}");
			WriteLine($"Product Name: {this.ProductName.ToString()}");
			WriteLine($"Price: {price}");
			WriteLine($"Quantity: {quant}");
			WriteLine($"AmountPayable: {ToDouble(this.AmountPayable = price*quant)}");
		}

        private void GetDetails()
        {
			WriteLine("enter product id: ");
			this.ProductId = ReadLine();

			WriteLine("enter product name: ");
			this.ProductName = ReadLine();

			WriteLine("enter price: ");
			this.Price = ReadLine();

			WriteLine("enter quantity: ");
			this.Quantity = ReadLine();
		}


    }
}
