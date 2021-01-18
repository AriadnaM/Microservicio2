using Microservicio2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservicio1Api.App_Data
{
    public class Context:DbContext
    {
        public DbSet<PersonaModel> PersonaModel { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPXAMOYA\\MSSQLSERVER;Database=Persona;Trusted_Connection=True;");
        }
    }
}
