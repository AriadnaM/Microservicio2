using Microservicio1Api.App_Data;
using Microservicio2.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservicio2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonaController:Controller
    {
        IPersonaRepository personaRepository;
        PersonaController()
        {
            personaRepository = new PersonaRepository(new Context());
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(personaRepository.GetPersonas());
        }
    }
}
