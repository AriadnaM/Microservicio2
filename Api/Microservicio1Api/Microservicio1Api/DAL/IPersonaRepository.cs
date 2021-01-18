using Microservicio2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservicio2.DAL
{
    interface IPersonaRepository: IDisposable
    {
        IEnumerable<PersonaModel> GetPersonas();
        PersonaModel GetPersonaModelById(int personaId);
        void InsertPersona(PersonaModel persona);
        void DeletePersona(int personaId);
        void UpdatePersona(PersonaModel persona);
        void Save();
    }
}
