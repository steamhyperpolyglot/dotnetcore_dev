using Microsoft.AspNetCore.Mvc;

namespace TicTacToe.Controllers
{
	public class GameInvitationController : Controller
	{
		// GET
		public IActionResult Index()
		{
			return View ();
		}
	}
}