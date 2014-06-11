using Ninject.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MonoLogging.Controllers
{
    public class HomeController : Controller
    {
        ILogger _logger;

        public HomeController(ILogger logger)
        {
            _logger = logger;
        }

        // GET: Home
        public ActionResult Index()
        {
            _logger.Info("Index page.");

            return View();
        }
    }
}
