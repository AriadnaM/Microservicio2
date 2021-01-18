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
    public class ParentescoController : Controller
    {
        static HttpClient client = new HttpClient();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateParentesco()
        {
            return View();
        }

        public async Task<PersonaModel> ConfirmCreatePersona(PersonaModel persona)
        {
            client.BaseAddress = new Uri("https://localhost:44329/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.PostAsJsonAsync(
            "parentesco/Create", persona);
            response.EnsureSuccessStatusCode();
            return persona;
        }


        public IActionResult DetailParentesco()
        {
            return View();
        }

        public async Task<IActionResult> DeleteParentesco(int parentescoId)
        {
            ParentescoModel parentesco = null;
            HttpResponseMessage response = await client.GetAsync("https://localhost:44329/parentesco/Detail{" + parentescoId + "}");
            if (response.IsSuccessStatusCode)
            {
                parentesco = await response.Content.ReadAsAsync<ParentescoModel>();
            }
            return View(parentesco);
        }

        public async Task<ParentescoModel> ConfirmDeleteParentesco(int parentescoId)
        {
            client.BaseAddress = new Uri("https://localhost:44329/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.PutAsJsonAsync(
            $"parentesco/Delete{parentescoId}", parentescoId);
            response.EnsureSuccessStatusCode();

            await response.Content.ReadAsAsync<ParentescoModel>();
            return null;
        }
    }
}
