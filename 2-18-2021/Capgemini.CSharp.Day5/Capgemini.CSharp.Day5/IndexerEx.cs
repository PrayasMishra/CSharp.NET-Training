using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Capgemini.CSharp.Day5
{
    class IndexerEx1
    {
       
        string[] names = new string[5];

        /*public string name
        {
            get {
                return _name;

            }

            set {
                _name = value;
            }
        }*/

        //indexer
        public string this[int i]
        {
            get {
                return names[i];
            }
            set {
                names[i] = value;
            }
        }

        static void Main(string[] args)
        {
            IndexerEx1 ind = new IndexerEx1();
            ind[0] = "a";
            ind[1] = "b";
            ind[2] = "c";
            ind[3] = "d";

            for (var i=0; i<5; i++)
            {
                WriteLine($"Name {i+1} : {ind[i]}");
            }
        }
    }
}
