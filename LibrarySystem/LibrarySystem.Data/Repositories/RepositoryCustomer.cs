using LibrarySystem.Data.Interfaces;
using LibrarySystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Data.Repositories
{
	public class RepositoryCustomer : RepositoryBase<Customer>, IRepositoryCustomer
	{
		public RepositoryCustomer(bool saveChanges = true) : base(saveChanges)
		{
		}
	}
}
