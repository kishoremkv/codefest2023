using Listeningear.Helpers;
using Core.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Listeningear.Controllers
{
	[Route("api/")]
	[ApiController]
	[EnableCors("AllowOrigin")]
	public class AuthController : Controller
	{

		[HttpGet]
		[Route("Authorization")]
		public IActionResult Authorization(string email, string password)
		{

			AdminModel user1 =null;
			foreach (var user in HelperClass.Adminlist)
			{
				if (user.email == email && user.password == password)
				{
					user1=user;
					break;
				}

			}
			
				return Ok(user1);
			

		}
		[HttpGet]
		[Route("GetUser")]
		public IActionResult GetUser(string email)
		{

			AdminModel user1 = null;
			foreach (var user in HelperClass.Adminlist)
			{
				if (user.email == email)
				{
					user1 = user;
					break;
				}

			}

			return Ok(user1.email);


		}


	}
}
