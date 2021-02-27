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
	class XMLDeserializationDemo
	{
		public WeatherForecast XML_Deserialize(string path, Type type)
		{
			FileStream fs = null;
			fs = File.OpenRead(path);

			XmlSerializer xmlSerializer = new XmlSerializer(type);
			WeatherForecast obj = xmlSerializer.Deserialize(fs) as WeatherForecast;

			if (obj != null)
			{
				return obj;
			}
			else 
			{
				throw new Exception("unable to deserialize....");
			}

		}

        static void Main(string[] args)
        {

			XMLDeserializationDemo demo = new XMLDeserializationDemo();
			string path = @"D:\Capgemini docs\Module1\files\weather_forcast.xml";
			var weather = demo.XML_Deserialize(path, typeof(WeatherForecast));
			WriteLine($"date: {weather.Date}\nTemp(in Celsius): {weather.TempCelsius}\n Remarks: {weather.Remarks}");

			ReadLine();
        }
	}
}
