using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace Capgemini.CSharp.Day10
{
	class IOExample
	{
		private FileStream fs = null;
        public IOExample(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }

		public void WriteToFile(string path)
		{
			StreamWriter sw = null;
			try
			{

				//to create a file with create mode and write access
				fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write);

				//StreamWriter - will take FileStream object
				sw = new StreamWriter(fs);

				//using Write or WriteLine to add properties into the file
				sw.WriteLine($"Id: {Id}");
				sw.WriteLine($"Name: {Name}");
				sw.WriteLine($"Age: {Age}");

				//Remove or clear the buffer memory
				sw.Flush();
			}
			catch (FileNotFoundException e)
			{
				WriteLine(e.Message);
			}
			catch (IOException e)
			{
				WriteLine(e.Message);
			}
			catch (Exception e)
			{
				WriteLine(e.Message);
			}
			finally
			{
				if (sw != null)
				{
					//close StreamWriter
					sw.Close();
				}
				if (fs != null)
				{
					//clode FileStream
					fs.Close();
				}
			}
		}

		public void ReadFromFile(string path)
		{
			StreamReader sr = null;
			try
			{
				fs = new FileStream(path, FileMode.Open, FileAccess.Read);
				StreamReader sw = new StreamReader(fs);

				WriteLine(sr.ReadToEnd());
			}
			catch (FileNotFoundException ex)
			{
				WriteLine(ex.Message);
			}
			catch (IOException ex)
			{
				WriteLine(ex.Message);
			}
			catch (Exception ex)
			{
				WriteLine(ex.Message);
			}
			finally
			{
				if (sr != null)
				{
					//close StreamWriter
					sr.Close();
				}
				if (fs != null)
				{
					//clode FileStream
					fs.Close();
				}
			}
		}

		static void Main(string[] args)
		{
			WriteLine("enter Id:");
			int id = int.Parse(ReadLine());

			WriteLine("enter Name:");
			string name = ReadLine();

			WriteLine("enter Age:");
			int age = int.Parse(ReadLine());

			IOExample obj = new IOExample(id,name,age);
			string path = @"D:\Capgemini docs\Module1\files\CustomerIO.txt";

			obj.WriteToFile(path);
			WriteLine("---------finished writing--------");

			obj.ReadFromFile(path);
			WriteLine("---------finished reading--------");

			ReadLine();
		}
	}
}
