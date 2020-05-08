using Microsoft.AspNetCore.Mvc;

namespace TicTacToe.Controllers
{
	public class HomeController : Controller
	{
		// GET
		public IActionResult Index()
		{
			return View ();
		}
	}
}