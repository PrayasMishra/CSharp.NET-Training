using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
using Newtonsoft.Json;

namespace Capgemini.CSharp.Day10
{

    class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderPrice { get; set; }
        public string Description { get; set; }
    }

    class JSONSerializationDemo
    {
        public void SerializeToJSON(List<Order> orderList, string path = null)
        {
            string orders = JsonConvert.SerializeObject(orderList);
            if (path != null)
            {
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine(orders);
                sw.Close();
            }
        }

        public List<Order> DeserializeFromJSON(string path)
        {
            string values = File.ReadAllText(path);

            var orders = JsonConvert.DeserializeObject<List<Order>>(values);

            if (orders != null)
            {
                return orders;
            }
            else
            {
                throw new Exception("unable deserialize from JSON");
            }
        }
        static void Main(string[] args)
        {
            string path = @"D:\Capgemini docs\Module1\files\Json_Order.txt";//file path
            JSONSerializationDemo obj = new JSONSerializationDemo();
            /*// Serialization code
            List<Order> orderList = new List<Order>
            {
                new Order{ Id = 1, OrderDate = DateTime.Now.AddDays(-1), OrderPrice = 45555.25m, Description = "Smart TV" },
                new Order{ Id = 2, OrderDate = DateTime.Now.AddDays(-1), OrderPrice = 20000.25m, Description = "Desk" }
            };

            
            obj.SerializeToJSON(orderList,path);
            */

            //Deserialization code
            List<Order> orderValues = obj.DeserializeFromJSON(path);
            foreach (var i in orderValues)
            {
                WriteLine($"{i.Id}\n{i.Description}\n{i.OrderDate}\n{i.OrderPrice}\n");
            }


            ReadLine();
        }
    }
}
