using Microservicio2Api.App_Data;
using Microservicio2Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservicio2Api.DAL
{
    public class ParentescoRepository : IParentescoRepository, IDisposable
    {
        private Context db;
        public ParentescoRepository(Context context)
        {
            db = context;
        }
        public void DeleteParentesco(int parentescoId)
        {
            ParentescoModel parentesco = db.Parentescos.Find(parentescoId);
            db.Parentescos.Remove(parentesco);
            Save();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ParentescoModel> GetParentescos()
        {
            return db.Parentescos.ToList();
        }

        public ParentescoModel GetParentescoModelById(int personaId)
        {
            return db.Parentescos.Find(personaId);
        }

        public void InsertParentesco(ParentescoModel parentesco)
        {
            db.Entry(parentesco);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void UpdateParentesco(ParentescoModel parentesco)
        {
            db.Entry(parentesco).State = EntityState.Modified;
            Save();
        }
    }
}
