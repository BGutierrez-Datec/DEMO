using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Demo.Controllers
{
	public class HelloWorldController : Controller
	{
		/// <summary>
		/// GET: /HelloWorld/
		/// </summary>
		/// <returns>Index.cshtml</returns>
		public IActionResult Index()
		{
			return View();
		}

		//
		// GET: /HelloWorld/Welcome/ 
		// Requires using System.Text.Encodings.Web;
		public string Welcome(string name, int numTimes = 2)
		{
			return HtmlEncoder.Default.Encode($"Hola {name}, Visitas: {numTimes}");
		}


	}
}
