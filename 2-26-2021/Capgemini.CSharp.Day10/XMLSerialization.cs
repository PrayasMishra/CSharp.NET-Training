using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
using System.Xml.Serialization;

namespace Capgemini.CSharp.Day10
{
    [Serializable]
   public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TempCelsius { get; set; }
        public string Remarks { get; set; }

        [NonSerialized]
        private string Test;

    }
    public class XMLSerializationDemo
    {
        public void Xml_Serializer(WeatherForecast obj, string path, Type type)
        {
            FileStream fs = null;
            fs = File.Create(path);

            XmlSerializer xmlser = new XmlSerializer(type);
            xmlser.Serialize(fs, obj);

            WriteLine("Complete XML Serialization");
            if (fs != null)
            {
                fs.Close();
            }
        }

        static void Main(string[] args)
        {
            string path = @"D:\Capgemini docs\Module1\files\weather_forcast.xml";

            WeatherForecast ob = new WeatherForecast()
            {
                Date = DateTime.Now,
                TempCelsius = 13,
                Remarks = "Blizzard"
            };

            XMLSerializationDemo demo = new XMLSerializationDemo();
            demo.Xml_Serializer(ob, path, typeof(WeatherForecast));

            ReadLine();
        }
    }
}

