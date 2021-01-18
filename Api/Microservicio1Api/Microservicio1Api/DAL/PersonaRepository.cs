using Microservicio1Api.App_Data;
using Microservicio2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservicio2.DAL
{
    public class PersonaRepository : IPersonaRepository, IDisposable
    {
        private Context db;
        public PersonaRepository(Context context)
        {
            db = context;
        }
        public void DeletePersona(int personaId)
        {
            PersonaModel persona = db.PersonaModel.Find(personaId);
            db.PersonaModel.Remove(persona);
            Save();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public PersonaModel GetPersonaModelById(int personaId)
        {
            return db.PersonaModel.Find(personaId);
        }

        public IEnumerable<PersonaModel> GetPersonas()
        {
            return db.PersonaModel.ToList();
        }

        public void InsertPersona(PersonaModel persona)
        {
            db.PersonaModel.Add(persona);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void UpdatePersona(PersonaModel persona)
        {
            db.Entry(persona).State = EntityState.Modified;
            Save();
        }
    }
}
