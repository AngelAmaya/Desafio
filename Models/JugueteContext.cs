using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Desafio.Models
{
    public class JugueteContext:DbContext
    {
        public JugueteContext(): base("JugueteContext") { }
        public DbSet<Juguete> Juguetes { get; set; }
    }
}