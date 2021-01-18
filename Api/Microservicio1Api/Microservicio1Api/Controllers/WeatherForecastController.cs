using Microservicio1Api.App_Data;
using Microservicio2.DAL;
using Microservicio2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservicio1Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        Microservicio2.DAL.IPersonaRepository personaRepository;
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            personaRepository = new PersonaRepository(new Context());
        }

        [HttpGet]
        public IEnumerable<PersonaModel> Get()
        {
            var rng = new Random();
            /*return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();*/

            return personaRepository.GetPersonas().ToArray();
        }
    }
}
