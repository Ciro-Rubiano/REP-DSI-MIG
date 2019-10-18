using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CU71
{
    public class Intervencion
    {

        private String domicilioReportado;
        private ArrayList<EstadoIntervencion> estados;
        private String nombreApellidoInformante;
        private String resumenSiniestroInformante;
        private String resumenTrabajoEfectuado;
        private String telefonoContacto;
        public ArrayList<Dotacion> dotacion;
        
        public Convocatoria convocatoria; //CHECK MULTIPLICITY
        public TipoSiniestro tipoSiniestro;
        public ArrayList<Material> materialesUtilizados;
        public Gravedad gravedad;
        public Bombero encargado;

        public int contarDotaciones()
        {
            return dotacion.Length;
        }

        public Boolean esFinalizada()
        {
            EstadoIntervencion estadoActual = this.obtenerEstadoActual();
            return estadoActual.esFinalizada();
        }

        public void finalizar(DateTime fechaActual)
        {
            this.getEstadoActual().finalizar(fechaActual, this);
        }

        public String getResumenTrabajo()
        {

            return this.resumenTrabajoEfectuado;
        }

        public String obtenerDatosDeEncargado()
        {

            return this.encargado.mostrarDatos();
        }

        public EstadoIntervencion obtenerEstadoActual()
        {
            EstadoIntervencion estadoActual; 
            foreach (EstadoIntervencion estado in estados)
            {
                if (estadoActual == null)
                {
                    estadoActual = estado;
                }
                else
                {
                    if(estado.fecha > estadoActual.fecha)
                    {
                        estadoActual = estado;
                    }
                }
            }
            return estadoActual;
        }

        public DateTime getFechaFinalizacion()
        {
            return this.buscarEstadoFinalizada().getFecha();
        }

        public EstadoIntervencion buscarEstadoFinalizada()
        {
            foreach (EstadoIntervencion estado in estados)
            {
                if (EstadoIntervencion.esFinalizada())
                {
                    return estado;
                }
            }
            return null;
        }

        public DateTime getFechaEnCurso()
        {
            return this.buscarEstadoEnCurso().getFecha();
        }

        public EstadoIntervencion buscarEstadoEnCurso()
        {
            foreach (EstadoIntervencion estado in estados)
            {
                if (EstadoIntervencion.esEnCurso())
                {
                    return estado;
                }
            }
            return null;
        }

        public Boolean EsEnCurso(){

            //retorna verdadero si la intervencion se encuentra en curso en este momento
            return (this.getEstadoActual().esEnCurso());

        }

    }

}
