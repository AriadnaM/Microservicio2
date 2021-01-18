using Microservicio2Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservicio2Api.DAL
{
    interface IParentescoRepository: IDisposable
    {
        IEnumerable<ParentescoModel> GetParentescos();
        ParentescoModel GetParentescoModelById(int personaId);
        void InsertParentesco(ParentescoModel parentesco);
        void DeleteParentesco(int parentescoId);
        void UpdateParentesco(ParentescoModel parentesco);
        void Save();
    }
}
