﻿using Microservicio2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservicio2.Controllers
{
    public class PersonaController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreatePersona(PersonaModel persona)
        {
            return View();
        }

        public IActionResult DetailPersona()
        {
            return View();
        }

        public IActionResult deletePersona()
        {
            return View();
        }
    }
}
