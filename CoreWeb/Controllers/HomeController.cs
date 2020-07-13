using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreWeb.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authentication;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Authorization;
using System.Text;

namespace CoreWeb.Controllers
{
    [Authorize]
    //避免Cross Site History Manipulation漏洞(用戶登出後，瀏覽器回上一頁仍可看到網頁的資安漏洞)
    [ResponseCache(NoStore = true)]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration config;

        public HomeController(ILogger<HomeController> logger, IConfiguration config)
        {
            _logger = logger;
            this.config = config;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            var isLogin = HttpContext.User.Identity.IsAuthenticated;
            //可以使用 HttpContext.User.Identity.IsAuthenticated 來判斷用戶是否登入
            //但由於此Action已經加上[Authorize]，表示會執行此Action的一定都是登入者，所以不必再脫褲子放屁XD
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<ul>");

            string Account = HttpContext.User.Claims.FirstOrDefault(m => m.Type == ClaimTypes.Name).Value;
            sb.AppendLine($@"<li>login account:{Account}</li>");

            foreach (Claim claim in HttpContext.User.Claims)
            {
                sb.AppendLine($@"<li>claim.Type:{claim.Type}, claim.value:{claim.Value}</li>");
            }
            sb.AppendLine("</ul>");

            ViewBag.msg = sb.ToString();
            return View();
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(string userid, string pd, string returnUrl)
        {   
            bool a = ModelState.IsValid;
            if (!userid.Equals("user") && !pd.Equals("Abc123"))
            {
                ViewBag.errMsg = "輸入錯誤";
                return View();
            }

            //取名Account，在登入後的頁面，讀取登入者的帳號會用得到，自己先記在大腦
            //Claim[] claims = new[] { new Claim("userid", userid) };
            Claim[] claims = new[] { new Claim(ClaimTypes.Name, userid) };
            //Scheme必填
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            ClaimsPrincipal principal = new ClaimsPrincipal(claimsIdentity);
            //執行登入，相當於以前的FormsAuthentication.SetAuthCookie()
            //從組態讀取登入逾時設定
            double loginExpireMinute = this.config.GetValue<double>("LoginExpireMinute");
            
            await HttpContext.SignInAsync(principal,
                new AuthenticationProperties()
                {
                    IsPersistent = false, //IsPersistent = false，瀏覽器關閉即刻登出
                                          //用戶頁面停留太久，逾期時間，在此設定的話會覆蓋Startup.cs裡的逾期設定
                    /* ExpiresUtc = DateTime.Now.AddMinutes(loginExpireMinute) */
                });

            //加上 Url.IsLocalUrl 防止Open Redirect漏洞
            if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Privacy");//到登入後的第一頁，自行決定
            }

        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return View();
        }

        public IActionResult AjaxTest()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult PostData()
        {
            return Content("Hello Ajax");
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
