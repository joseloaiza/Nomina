using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Nomina.Web.Controllers
{
    public class EmpleoyesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}