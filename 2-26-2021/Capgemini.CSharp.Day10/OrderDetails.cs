using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
using System.Runtime.Serialization;

namespace Capgemini.CSharp.Day10
{
    [DataContract]
    class OrderDetails
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime OrderDate { get; set; }
        [DataMember]
        public decimal OrderPrice { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
