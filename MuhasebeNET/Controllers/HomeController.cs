using Microsoft.AspNetCore.Mvc;
using MuhasebeNET.Domain.Entities;
using MuhasebeNET.Models;
using System.Diagnostics;

namespace MuhasebeNET.Controllers
{
	public class HomeController : Controller
	{


	
		public IActionResult Login()
		{
			return View();
			
		}


	}
}