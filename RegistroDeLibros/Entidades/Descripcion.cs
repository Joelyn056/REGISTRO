using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace RegistroDeLibros.Entidades
{
    public class Descripcion
    {
        public int LibroId { get; set; }

        public string Nombre { get; set; }

        public string Tamaño { get; set; }

        public string CantOjas { get; set; }


        public Descripcion()
        {

            LibroId = 0;
            Nombre = string.Empty;
            Tamaño = string.Empty;
            CantOjas = string.Empty;
        }
    }
}
