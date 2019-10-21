using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CU71
{
    public class Usuario
    {
        private String contraseña;
        private DateTime fechaAlta;
        private String nombre;
        private Perfil perfil;

        public String getNombre()
        {
            return this.nombre;
        }

        public void setNombre(String value)
        {
            this.nombre = value;
        }

        public DateTime getFechaAlta()
        {
            return this.fechaAlta;
        }

        public void setFechaAlta(DateTime value)
        {
            this.fechaAlta = value;
        }

        public Perfil getPerfil()
        {
            return this.perfil;
        }

        public void setPerfil(Perfil value)
        {
            this.perfil = value;
        }

        // COMO MANEJAMOS CONTRASEÑAS?
        public String getContraseña()
        {
            return this.contraseña;
        }

        public void setContraseña(String value)
        {
            this.contraseña = value;
        }
    }
}