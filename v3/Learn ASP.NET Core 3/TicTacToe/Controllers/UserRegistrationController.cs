using Microsoft.AspNetCore.Mvc;

namespace TicTacToe.Controllers
{
	public class UserRegistration : Controller
	{
		// GET
		public IActionResult Index()
		{
			return View ();
		}
	}
}