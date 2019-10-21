using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CU71
{
    public class Permiso
    {
        private String descripcion;
        private String nombre;

        public String getDescripcion()
        {
            return this.descripcion;
        }

        public void setDescripcion(String value)
        {
            this.descripcion = value;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public void setNombre(String value)
        {
            this.nombre = value;
        }
    }
}