using LibrarySystem.Data.Models;
using LibrarySystem.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace LibrarySystem.Web.Controllers
{
	public class CustomerController : Controller
	{
		private ServiceCustomer serviceCustomer = new ServiceCustomer();
		public IActionResult Index()
		{
			List<Customer> listCustomer = serviceCustomer.RepositoryCustomerProp.GetAll();
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
				serviceCustomer.RepositoryCustomerProp.Include(customer);
				return RedirectToAction("Index");
			}

			return View();
		}

		public IActionResult Details(int id)
		{
			Customer customer = serviceCustomer.RepositoryCustomerProp.GetPrimaryKey(id);

			return View(customer);
		}

		public IActionResult Edit(int id)
		{
			Customer customer = serviceCustomer.RepositoryCustomerProp.GetPrimaryKey(id);

			return View(customer);
		}

		[HttpPost]
		public IActionResult Edit(Customer customer)
		{
			Customer EditCustomer = serviceCustomer.RepositoryCustomerProp.Edit(customer);

			return RedirectToAction("Details", new {EditCustomer.Id});
		}

		public IActionResult Delete(int id)
		{
			serviceCustomer.RepositoryCustomerProp.Delete(id);
			return RedirectToAction("Index");
		}
	}
}
