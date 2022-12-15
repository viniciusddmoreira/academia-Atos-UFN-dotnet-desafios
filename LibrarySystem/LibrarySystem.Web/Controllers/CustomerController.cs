using LibrarySystem.Data.Models;
using LibrarySystem.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace LibrarySystem.Web.Controllers
{
	public class CustomerController : Controller
	{
		private ServiceCustomer _serviceCustomer = new ServiceCustomer();
		public IActionResult Index()
		{
			List<Customer> listCustomer = _serviceCustomer.RepositoryCustomerProp.GetAll();
			return View(listCustomer);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(Customer customer)
		{
			if (ModelState.IsValid)
			{
				_serviceCustomer.RepositoryCustomerProp.Include(customer);
				return RedirectToAction("Index");
			}

			return View();
		}

		public IActionResult Details(int id)
		{
			Customer customer = _serviceCustomer.RepositoryCustomerProp.GetPrimaryKey(id);

			return View(customer);
		}

		public IActionResult Edit(int id)
		{
			Customer customer = _serviceCustomer.RepositoryCustomerProp.GetPrimaryKey(id);

			return View(customer);
		}

		[HttpPost]
		public IActionResult Edit(Customer customer)
		{
			Customer editCustomer = _serviceCustomer.RepositoryCustomerProp.Edit(customer);

			return RedirectToAction("Details", new {editCustomer.Id});
		}

		public IActionResult Delete(int id)
		{
			_serviceCustomer.RepositoryCustomerProp.Delete(id);
			return RedirectToAction("Index");
		}
	}
}
