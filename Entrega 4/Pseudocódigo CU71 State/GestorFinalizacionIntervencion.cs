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
            List<Intervencion> intervencionesEnCurso = new List<Intervencion>();
            foreach (Intervencion inter in intervenciones)
            {
                if (inter.esEnCurso())
                {
                    intervencionesEnCurso.Add(inter)
                }
            }
            // Se envia a la ventana las intervenciones en curso y 
            // continúa la logica del caso de Uso.No se escribe código por simplicidad

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
