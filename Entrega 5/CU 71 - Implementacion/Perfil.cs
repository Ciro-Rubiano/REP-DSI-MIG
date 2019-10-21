using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CU71
{
    public class Perfil
    {
        private String descripcion;
        private String nombre;
        private List<Permiso> permisos;

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

        public void agregarPermiso(Permiso value)
        {
            this.permisos.Add(value);
        }

        public void eliminarPermiso(Permiso value)
        {
            this.permisos.Remove(value);
        }
    }
}