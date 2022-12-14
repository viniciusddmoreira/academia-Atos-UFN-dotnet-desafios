using LibrarySystem.Data.Interfaces;
using LibrarySystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Data.Repositories
{
	public class RepositoryBook : RepositoryBase<Book>, IRepositoryBook
	{
		public RepositoryBook(bool saveChanges = true) : base(saveChanges)
		{
		}
	}
}
