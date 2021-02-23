using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Capgemini.CSharp.Day7
{
	class ProductMock
	{
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public double Price { get; set; }

		public ProductMock()
		{
			ProductId = 0;
			ProductName = null;
			Price = 0.0d;
		}

		public ProductMock(int Id, string PName, double Pr)
		{
			ProductId = Id;
			ProductName = PName;
			Price = Pr;
		}

		public void GetProductDetails()
		{
			WriteLine("enter ID: ");
			ProductId = int.Parse(ReadLine());
			WriteLine("enter Product Name: ");
			ProductName = ReadLine();
			WriteLine("enter Price: ");
			Price = double.Parse(ReadLine());
			
			//condition checks
			if (ProductId <= 0)
			{
				throw new DataEntryException("Product ID must be greater than zero");
			}
			if (ProductName == "")
			{
				throw new DataEntryException("Product Name cannot be left blank");
			}
			if (Price <= 0)
			{
				throw new DataEntryException("Price of product must be greater than zero");
			}
		}

        public void DisplayDetails(ProductMock p)
        {
            WriteLine($"Product Id={p.ProductId}, Product Name:{p.ProductName}, Price:{p.Price}");
        }
    }

	class ProductTest
	{
	
		static void Main(string[] args)
		{
			try
			{
				ProductMock prodmock = new ProductMock();
				prodmock.GetProductDetails();
				new ProductMock().DisplayDetails(prodmock);
			}
			catch (DataEntryException dee)
			{
				WriteLine($"user defined exception: {dee.Message}");
			}
			catch (Exception e)
			{
				WriteLine($"base exception: {e.Message}");
			}
			finally { 
				ReadLine();
			}
		}
	}
}
