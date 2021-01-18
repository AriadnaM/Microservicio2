using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservicio2.Controllers
{
    public class ParentescoController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateParentesco()
        {
            return View();
        }

        public IActionResult DetailParentesco()
        {
            return View();
        }

        public IActionResult DeleteParentesco()
        {
            return View();
        }
    }
}
