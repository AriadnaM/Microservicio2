using Microservicio2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Microservicio2.Controllers
{
    public class PersonaController:Controller
    {
        static HttpClient client = new HttpClient();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreatePersona()
        {
            return View();
        }

        public async Task<PersonaModel> ConfirmCreatePersona(PersonaModel persona)
        {
            client.BaseAddress = new Uri("https://localhost:44321/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.PostAsJsonAsync(
            "persona/Create", persona);
            response.EnsureSuccessStatusCode();
            return persona;
        }

        public async Task<IActionResult> DetailPersona()
        {
            PersonaModel persona = null;
            HttpResponseMessage response = await client.GetAsync("https://localhost:44321/persona/Detail/1");
            if (response.IsSuccessStatusCode)
            {
                persona = await response.Content.ReadAsAsync<PersonaModel>();
            }
            return View(persona);
        }

        public IActionResult deletePersona()
        {
            return View();
        }
    }
}
