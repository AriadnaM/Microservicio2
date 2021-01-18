using Microservicio2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservicio2.DAL
{
    public class PersonaRepository : IPersonaRepository
    {
        public void DeletePersona(int personaId)
        {
            throw new NotImplementedException();
        }

        public PersonaModel GetPersonaModelById(int personaId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonaModel> GetPersonas()
        {
            throw new NotImplementedException();
        }

        public void InsertPersona(PersonaModel persona)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdatePersona(PersonaModel persona)
        {
            throw new NotImplementedException();
        }
    }
}
