using LibrarySystem.Data.Models;
using LibrarySystem.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.Web.Controllers
{
	public class BookController : Controller
	{
		private ServiceBook _serviceBook = new ServiceBook();
		public IActionResult Index()
		{
			List<Book> listBook = _serviceBook.RepositoryBookProp.GetAll();
			return View(listBook);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(Book book)
		{
			if (ModelState.IsValid)
			{
				_serviceBook.RepositoryBookProp.Include(book);
				return RedirectToAction("Index");
			}

			return View();
		}

		public IActionResult Details(int id)
		{
			Book book = _serviceBook.RepositoryBookProp.GetPrimaryKey(id);

			return View(book);
		}

		public IActionResult Edit(int id)
		{
			Book book = _serviceBook.RepositoryBookProp.GetPrimaryKey(id);

			return View(book);
		}

		[HttpPost]
		public IActionResult Edit(Book book)
		{
			Book editBook = _serviceBook.RepositoryBookProp.Edit(book);

			return RedirectToAction("Details", new { editBook.Id });
		}

		public IActionResult Delete(int id)
		{
			_serviceBook.RepositoryBookProp.Delete(id);
			return RedirectToAction("Index");
		}
	}
}
