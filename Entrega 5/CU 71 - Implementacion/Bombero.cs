using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CU71
{
    public class Bombero
    {
        private Boolean activo;
        private string apellido;
        private string direccion;
        private string dni;
        private string email;
        private DateTime fechaNacimiento;
        private string nombre;
        private string telefono;
        private List<Asistencia> asistencias;
        private Rol rol;
        private Usuario usuario;
        private List<Disponibilidad> disponibilidad;

        public Boolean esActivo()
        {
            return this.activo;
        }

        public Boolean esTuRol(Rol rolComp)
        {
            return this.Getrol().equals(rolComp);
        }

        public Boolean esTuUsuario(Usuario user)
        {
            return this.Getusuario().equals(user);
        }

        public String mostrarAsistencias()
        {
            String salida = "";
            foreach (Asistencia asist in asistencias)
            {
                salida += (asist.ToString() + "\n");
            }
            return salida;
        }

        public String mostrarDatos()
        {
            String salida = "";
            salida += "Nombre: " + Getnombre();
            salida += "\nApellido: " + Getapellido();
            salida += "\nDNI: " + Getdni();
            salida += "\nDireccion: " + Getdireccion();
            salida += "\nEmail: " + Getemail();
            salida += "\nTelefono: " + Gettelefono();
            salida += "\nFecha de nacimiento: " + GetfechaNacimiento().ToShortDateString();
            return salida;
        }

        public Boolean registrarIngreso(DateTime ingreso)
        {
            throw new NotImplementedException();
        }

        public string Getapellido()
        {
            return apellido;
        }

        public void Setapellido(string value)
        {
            apellido = value;
        }

        public string Getdireccion()
        {
            return direccion;
        }

        public void Setdireccion(string value)
        {
            direccion = value;
        }
        
        public string Getdni()
        {
            return dni;
        }

        public void Setdni(string value)
        {
            dni = value;
        }

        public string Getemail()
        {
            return email;
        }

        public void Setemail(string value)
        {
            email = value;
        }

        public DateTime GetfechaNacimiento()
        {
            return fechaNacimiento;
        }

        public void SetfechaNacimiento(DateTime value)
        {
            fechaNacimiento = value;
        }

        public string Getnombre()
        {
            return nombre;
        }

        public void Setnombre(string value)
        {
            nombre = value;
        }

        public string Gettelefono()
        {
            return telefono;
        }

        public void Settelefono(string value)
        {
            telefono = value;
        }

        public Rol Getrol()
        {
            return rol;
        }

        public void Setrol(Rol value)
        {
            rol = value;
        }

        public Usuario Getusuario()
        {
            return usuario;
        }

        public void Setusuario(Usuario value)
        {
            usuario = value;
        }
    }
}