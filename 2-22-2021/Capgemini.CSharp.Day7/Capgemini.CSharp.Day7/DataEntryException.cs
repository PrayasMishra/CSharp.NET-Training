using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CSharp.Day7
{
    class DataEntryException : ApplicationException
    {
        public DataEntryException()
        {
        }

        public DataEntryException(string message) : base(message)
        {
        }
    }
}
