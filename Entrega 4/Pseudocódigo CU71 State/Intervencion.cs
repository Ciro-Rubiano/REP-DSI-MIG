using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CU71
{
    public class Intervencion
    {

        private String domicilioReportado;
        private EstadoIntervencion[] estados;
        private String nombreApellidoInformante;
        private String resumenSiniestroInformante;
        private String resumenTrabajoEfectuado;
        private String telefonoContacto;
        public Dotacion dotacion;
        public Convocatoria convocatoria;
        public TipoSiniestro tipoSiniestro;
        public Material materialesUtilizados;
        public HistorialIntervencion historial;
        public Gravedad gravedad;
        public Bombero encargado;

        public void anadirEstado(EstadoIntervencion estado)
        {
            
        }

        public void finalizar(DateTime fechaActual)
        {
            this.getEstadoActual().finalizar(fechaActual, this);
        }

        public EstadoIntervencion obtenerEstadoActual()
        {
            EstadoIntervencion estadoActual;
            foreach (EstadoIntervencion estado in estados)
            {

            }
            return estadoActual;
        }
        
    }
}
