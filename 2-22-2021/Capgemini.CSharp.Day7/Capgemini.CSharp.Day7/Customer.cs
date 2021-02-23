using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CSharp.Day7
{
	class Customer
	{
		int CustomerId { get; set; }
		string CustomerName { get; set; }
		string Address { get; set; }
		string City { get; set; }
		int Phone { get; set; }
		decimal CreditLimit { get; set; }

		Customer()
		{
			CustomerId = 0;
			CustomerName = null;
			Address = null;
			City = null;
			Phone = 0;
			CreditLimit = 0.0m;
		}

		Customer(int CustId, string CustName, string Addr, string Cit, int Ph, decimal CLim)
		{
			CustomerId = CustId;
			CustomerName = CustName;
			Address = Addr;
			City = Cit;
			Phone = Ph;
			CreditLimit = CLim;

		}
	}
}
