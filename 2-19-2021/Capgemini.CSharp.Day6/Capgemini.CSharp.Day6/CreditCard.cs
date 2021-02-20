using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CSharp.Day6
{
    class CreditCard
    {
       /* public string PrintCardNo(string cardNo)
        {
            return string.Concat(cardNo.Split('-'));
        }*/
    }

    class CreditCardExecute
    {
        static void Main(string[] args)
        {
            CreditCard card = new CreditCard();
            //string cardNo = card.PrintCardNo("9897-465-4545");
            string cardNo = "9897-465-4545";
            string s = cardNo.PrintCardNo();
            Console.WriteLine($"cardNo : {s}");

            Console.ReadKey();
        }
    }
}
