using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using CoreWeb.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLog;

namespace CoreWeb.Controllers
{
    public class HelloWorldController : Controller
    {
        private readonly ILogger<HelloWorldController> _logger;

        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            try
            {
                string logPath = (NLog.LogManager.Configuration.FindTargetByName("f") as NLog.Targets.FileTarget)
                    .FileName.Render(new LogEventInfo() { TimeStamp = DateTime.Now, LoggerName = "loggerName" });
                this._logger.LogInformation(".net core api 測試");
                HelloWorldVM = new HelloWorldViewModel()
                {
                    HelloWorld = "Hello World~~~",
                    Memo = logPath
                };

                return View(HelloWorldVM);
            }
            catch (Exception ex)
            {
                return Content(ex.Message.ToString());
            }
        }

        public HelloWorldViewModel HelloWorldVM { get; set; }

        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is {numTimes}");
        }
    }
}
