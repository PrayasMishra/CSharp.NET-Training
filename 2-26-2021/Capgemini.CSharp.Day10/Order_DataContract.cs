using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
using System.Runtime.Serialization.Json;

namespace Capgemini.CSharp.Day10
{
	class Order_DataContract
	{
		public void DataContractSerialize(List<OrderDetails> orderList, string path, Type type)
		{
			DataContractJsonSerializer data = new DataContractJsonSerializer(type);
			FileStream fs = File.Create(path);
			data.WriteObject(fs, orderList);	
		}

		public List<OrderDetails> DataContractDeserialize(string path, Type type)
		{
			DataContractJsonSerializer data = new DataContractJsonSerializer(type);
			FileStream fs = File.OpenRead(path);
			List<OrderDetails> orderVals = data.ReadObject(fs) as List<OrderDetails>;
			if (orderVals != null)
			{
				return orderVals;
			}
			else
			{
				throw new Exception("unable to deserialize");
			}
			
		}

		static void Main(string[] args)
        {
			string path = @"D:\Capgemini docs\Module1\files\order_data_contract2.txt";
			Order_DataContract dataContract = new Order_DataContract();
			/*
			List<OrderDetails> orderList = new List<OrderDetails>
			{
				new OrderDetails{ Id = 100, OrderDate = DateTime.Now.AddDays(-1), OrderPrice = 40000.25m, Description = "Smart TV" },
				new OrderDetails{ Id = 101, OrderDate = DateTime.Now.AddDays(-1), OrderPrice = 20000.25m, Description = "Desk" }
			};
			dataContract.DataContractSerialize(orderList,path,typeof(List<OrderDetails>));
			*/
			var orderValues = dataContract.DataContractDeserialize(path, typeof(List<OrderDetails>));

			foreach (var x in orderValues)
			{
				WriteLine($"OrderDetails Id :{x.Id}\nOrder Date :{x.OrderDate}\nDescription :{x.Description}\nOrder Price :{x.OrderPrice}");
			}

			ReadLine();
		}
	}
}
