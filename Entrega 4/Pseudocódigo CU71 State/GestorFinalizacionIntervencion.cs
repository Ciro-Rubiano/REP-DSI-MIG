using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace CU71
{
    public class GestorFinalizacionIntervencion
    {

        private Bombero bomberos;
        private String datosIngresadosDotacion;
        private Intervencion[] intervenciones;
        private Intervencion intervencionSeleccionada;
        private Sesion sesionActual;

        public void buscarIntervencionesEnCurso()
        {

            foreach (Intervencion inter in intervenciones)
            {
                // Duda de como manejar esto, porque tengo que buscar las intervenciones para
                // mandarle datos a la interfaz visual para que el usuario seleccione una
                if (inter.esEnCurso())
                {

                }
            }
        }

        public DateTime obtenerFechaHoraActual()
        {
            return System.DateTime.Now;
        }
        
        public void registrarFinalizacionIntervencion()
        {
            DateTime fechaActual = this.obtenerFechaHoraActual();
            intervencionSeleccionada.finalizar(fechaActual);
        }

    }//end GestorFinalizacionIntervencion
}
