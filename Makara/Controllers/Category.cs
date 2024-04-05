using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace StajProje.Controllers
{
	public class Category : Controller
	{
		CategoryManager cm = new CategoryManager(new EfCategoryRepository());
		public IActionResult Index()
		{
			var values = cm.GetList();

			return View(values);
		}
	}
}
