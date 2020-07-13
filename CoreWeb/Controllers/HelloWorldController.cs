using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using CoreWeb.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CoreWeb.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            HelloWorldVM = new HelloWorldViewModel();
            HelloWorldVM.HelloWorld = "Hello World~~~";
            HelloWorldVM.Memo = "Index page test / Hey Hey Test ";
            return View(HelloWorldVM);
        }

        public HelloWorldViewModel HelloWorldVM { get; set; }

        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is {numTimes}");
        }
    }
}
