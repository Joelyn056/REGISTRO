using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RegistroDeLibros.Entidades;
using System.Data.Entity;

namespace RegistroDeLibros.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Descripcion> Libro { get; set; }

        public Contexto() :base("ConStr")
        { }
    }
    
}
