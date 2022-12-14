using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Data.Interfaces
{
	public interface IRepositoryModel<T> where T : class
	{
		List<T> GetAll();
		T GetPrimaryKey(params object[] variable);
		T Include(T _object );
		T Edit(T _object);
		void Delete(T _object);
		void Delete(params object[] variable);
		void SaveChanges();

	}
}
