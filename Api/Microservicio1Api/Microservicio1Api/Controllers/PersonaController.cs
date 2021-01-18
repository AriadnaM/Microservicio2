using Microservicio1Api.App_Data;
using Microservicio2.DAL;
using Microservicio2.Models;
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
        public PersonaController()
        {
            personaRepository = new PersonaRepository(new Context());
        }

        [HttpGet]
        public IEnumerable<PersonaModel> Index()
        {
            return personaRepository.GetPersonas().ToArray();
        }

        [HttpGet("{id}")]
        public PersonaModel Detail(int id)
        {
            return personaRepository.GetPersonaModelById(id);
        }

        [HttpPut("{id}")]
        public void Delete(int id)
        {
            personaRepository.DeletePersona(id);
        }

        [HttpPost]
        public PersonaModel Create(PersonaModel persona)
        {
            personaRepository.InsertPersona(persona);
            return persona;
        }
    }
}
