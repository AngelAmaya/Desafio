using Desafio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Desafio.Services
{
    public class JugueteRepository
    {
        public List<Juguete> ObtenerTodos() {
            using (var db = new JugueteContext()) {
                return db.Juguetes.ToList();
            }
        }

        internal void Create(Juguete model)
        {
            using (var db =  new JugueteContext()) {
                db.Juguetes.Add(model);
                db.SaveChanges();
            }
        }

        internal void Edit(Juguete model)
        {
            using (var db = new JugueteContext())
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        internal void Remove(Juguete model)
        {
            using (var db = new JugueteContext())
            {
                db.Juguetes.Remove(model);
                db.SaveChanges();
            }
        }
    }
}