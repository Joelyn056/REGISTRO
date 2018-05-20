using RegistroDeLibros.DAL;
using RegistroDeLibros.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace RegistroDeLibros.BLL
{
    public class Libro
    {
        public static bool Guardar(Libro libro)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.libro.add(libro) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }

                contexto.Dispose();
            }
            catch
            {
                throw;
            }
            return paso;
        }


        public static bool Editar(Libro libro)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(Libro).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Libro libro = contexto.libro.find(id);

                contexto.libro.Remove(libro);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;

        }
    }
}
