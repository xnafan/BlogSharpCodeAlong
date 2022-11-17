using BlogSharpCodeAlongWebsite.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BlogSharpCodeAlongWebsite.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login() => View();

        //receives the login form on submit
        [HttpPost]
        public ActionResult Login([FromForm] LoginModel loginInfo, [FromQuery] string returnUrl)
        {
            if (loginInfo.Password == "secretWord")
            {
                SignIn(loginInfo);
            }

            //if (user != null) { await SignIn(user); }
            //if (string.IsNullOrEmpty(returnUrl)) { return RedirectToAction(); }
            return View();
        }
        private async Task SignIn(LoginModel loginInfo)
        {

            //store all the claims we want
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Email, loginInfo.Email),
        };
            //put them into the MS identity framework
            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            //store them in a cookie on the client
            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity),
                new AuthenticationProperties());


        }
    }
}
