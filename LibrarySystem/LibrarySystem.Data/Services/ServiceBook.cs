using LibrarySystem.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Data.Services
{
	public class ServiceBook
	{
		public RepositoryBook RepositoryBookProp { get; set; }

		public ServiceBook()
		{
			RepositoryBookProp = new RepositoryBook();
		}

	}
}
