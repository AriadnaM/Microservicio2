using Microservicio2Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservicio2Api.App_Data
{
    public class Context:DbContext
    {
        public DbSet<ParentescoModel> Parentescos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPXAMOYA\SQLEXPRESS;Database=Familia;Trusted_Connection=True;");
        }
    }
}
