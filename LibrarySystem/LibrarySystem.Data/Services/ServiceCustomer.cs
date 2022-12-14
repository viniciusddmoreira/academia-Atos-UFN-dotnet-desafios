using LibrarySystem.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Data.Services
{
	public class ServiceCustomer
	{
		public RepositoryCustomer RepositoryCustomerProp { get; set; }

		public ServiceCustomer()
		{
			RepositoryCustomerProp = new RepositoryCustomer();
		}
	}
}
