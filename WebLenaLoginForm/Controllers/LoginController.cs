using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebLenaLoginForm.Models;
using System.Security.Cryptography;

namespace WebLenaLoginForm.Controllers
{
    public class LoginController : Controller
    {

        Context c=new Context();

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        public async Task<IActionResult> Login(Login p)
        {

            var bilgiler=c.Logins.FirstOrDefault(x=>x.UserName==p.UserName && x.Password== p.Password);

            if(bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.UserName)
                };
                var useridentity=new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal=new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Form");


            }

			return View();
        }

		public async Task<ActionResult> Logout()
		{
			return RedirectToAction("Login");
		}

	}
}
