using LibrarySystem.Data.Interfaces;
using LibrarySystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Data.Repositories
{
	public class RepositoryBase<T> : IRepositoryModel<T>, IDisposable where T : class
	{
		protected LibrarySystemContext _Context;
		public bool _SaveChanges = true;

		public RepositoryBase(bool saveChanges = true)
		{
			_Context = new LibrarySystemContext();
			_SaveChanges = saveChanges;
		}
		public void Delete(T _object)
		{
			_Context.Set<T>().Remove(_object);

			if (_SaveChanges)
			{
				_Context.SaveChanges();
			}
		}

		public void Delete(params object[] variable)
		{
			var obj = GetPrimaryKey(variable);
			Delete(obj);
		}

		public void Dispose()
		{
			_Context.Dispose();
		}

		public T Edit(T _object)
		{
			_Context.Entry(_object).State = EntityState.Modified;

			if (_SaveChanges)
			{
				_Context.SaveChanges();
			}

			return _object;
		}

		public List<T> GetAll()
		{
			return _Context.Set<T>().ToList();
		}

		public T GetPrimaryKey(params object[] variable)
		{
			return _Context.Set<T>().Find(variable);
		}

		public T Include(T _object)
		{
			_Context.Set<T>().Add(_object);

			if (_SaveChanges)
			{
				_Context.SaveChanges();

			}

			return _object;
		}

		public void SaveChanges()
		{
			_Context.SaveChanges();
		}
	}
}
