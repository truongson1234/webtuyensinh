using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using webtuyensinh.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authorization;
using webtuyensinh.Filters;

namespace webtuyensinh.Controllers
{
    [RedirectIfAuthenticated]
    public class AccountController : Controller
    {
        private readonly WebtuyensinhDbContext _context;

        public AccountController (WebtuyensinhDbContext context)
        {
            _context = context;
        }
        [Route("/register")]
        public IActionResult SignIn()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        [Route("/signin")]
        public async Task<IActionResult> SignIn(UserModel userModel)
        {
            
            return View();
        }
        [Route("/login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/login")]
        public async Task<IActionResult> Login([Bind("UserName, Password")] UserModel UserModel)
        {
            var user = await _context.UserModel
                .FirstOrDefaultAsync(u => u.UserName == UserModel.UserName && u.Password == UserModel.Password);

            if (user != null)
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier, Convert.ToString(user.Id)),
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.Role, user.Role),
                    new Claim("Webtuyensinh", "code")
                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                Console.WriteLine(Request.Headers["Referer"].ToString());
                return Redirect(Request.Headers["Referer"].ToString()); ;
            }

            return View();
        }
        [Route("/logout")]
        public async Task<IActionResult> Logout()
        {
            // Clear the existing external cookie
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);
            return LocalRedirect("/");
        }
    }
}
