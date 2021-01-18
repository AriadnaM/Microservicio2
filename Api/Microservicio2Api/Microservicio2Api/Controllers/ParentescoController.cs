using Microservicio2Api.App_Data;
using Microservicio2Api.DAL;
using Microservicio2Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservicio2Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParentescoController: Controller
    {
        IParentescoRepository parentescoRepository;
        public ParentescoController()
        {
            parentescoRepository = new ParentescoRepository(new Context());
        }

        [HttpGet]
        public IEnumerable<ParentescoModel> Index()
        {
            return parentescoRepository.GetParentescos().ToArray();
        }

        [HttpGet("{id}")]
        public ParentescoModel Detail(int id)
        {
            return parentescoRepository.GetParentescoModelById(id);
        }

        [HttpPut("{id}")]
        public void Delete(int id)
        {
            parentescoRepository.DeleteParentesco(id);
        }

        [HttpPost]
        public ParentescoModel Create(ParentescoModel persona)
        {
            parentescoRepository.InsertParentesco(persona);
            return persona;
        }
    }
}
