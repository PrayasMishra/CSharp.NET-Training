using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace Capgemini.CSharp.Day10
{
	[Serializable]
	public class Product
	{
		public int Id { get; set; }
		public string ProductName { get; set; }
		public decimal Price { get; set; }
		
		private int Qty;

		public void SoapSerializer(Product prod, string path)
		{
			FileStream fs = null;
			SoapFormatter soapFormatter = new SoapFormatter();
			fs = File.Create(path);
			soapFormatter.Serialize(fs,prod);
			if (fs != null)
			{
				fs.Close();
			}
			else 
			{
				throw new Exception("problem in serialization...");
			}
		}

		public Product SoapDeserializer(string path)
		{
			FileStream fs = null;
			fs = File.OpenRead(path);

			SoapFormatter formatter = new SoapFormatter();
			var prodObj = formatter.Deserialize(fs) as Product;

			if (prodObj != null)
			{
				return prodObj;
			}
			else
			{
				throw new Exception("unable to deserialize with SOAP.");
			}
		}

        static void Main(string[] args)
        {
			string path = @"D:\Capgemini docs\Module1\files\Product.xml";
			Product prod = new Product()
			{
				Id = 100,
				ProductName = "Acer Laptop",
				Price = 34000.00m,
				Qty = 2
			};

			prod.SoapSerializer(prod,path);
			WriteLine("Product Serialized...");

			Product product = new Product().SoapDeserializer(path);
			WriteLine($"Id: {product.Id}\nName: {product.ProductName}\nPrice: {product.Price}\nQty: {product.Qty}");
        }
	}
}
