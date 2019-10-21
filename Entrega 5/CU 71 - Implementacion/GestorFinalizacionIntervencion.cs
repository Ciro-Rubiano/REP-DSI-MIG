using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace CU71
{
    public class GestorFinalizacionIntervencion
    {

        private ArrayList<Bombero> bomberos;
        private String datosIngresadosDotacion;
        private List<Intervencion> intervenciones;
        private Intervencion intervencionSeleccionada;
        private Sesion sesionActual;

        private List<Intervencion> intervencionesEnCurso;

        //methods --------------------------------

        public void finalizarIntervencion(){
            throw new NotImplementedException();

            Bombero deSesion = this.obtenerBomberoSesionActual();
            //TODO: ENVIAR ROL POR PARAMETRO AL BOMBERO, CONSULTANDO SI ES DE TIPO "EncargadoDeGuardia"
            this.buscarIntervencionesEnCurso();
            this.OrdenarIntervencionesEnCurso();
            this.MostrarIntervencionesEnCurso();//CHECK
        }

        public void SeleccionarIntervencionAFinalizar(int index){
            //metodo utilizado por la GUI para seleccionar la itervencion a finalizar
            this.intervencionSeleccionada = intervencionesEnCurso[index];
            List<Dotacion> dotacionesDeIntervencion = this.intervencionSeleccionada.GetDotaciones();
            //mostramos dotaciones
            
        }
        
        private Bombero obtenerBomberoSesionActual(){
            //obtiene el usuario actual en base a la sesion
            foreach (Bombero bombero in bomberos){
                if(bombero.esTuUsuario(sesionActual.GetUsuario()));
                return bombero;
            }

        }
        
        public void buscarIntervencionesEnCurso()
        {
            List<Intervencion> intervencionesEnCurso = new List<Intervencion>();
            foreach (Intervencion inter in intervenciones)
            {
                if (inter.EsEnCurso())
                {
                    this.intervencionesEnCurso.Add(inter);
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

        private void MostrarIntervencionesEnCurso(){
            throw new NotImplementedException();
            //Conexion con la GUI - Mostrar Intervenciones en curso.
        }

        private void OrdenarIntervencionesEnCurso(){

            throw new NotImplementedException();

            //sort algorithm. Using comparer.
            this.intervencionesEnCurso.Sort(new Comparer{
                //Redefinir methods
                //TODO
            });

        }

    

    }//end GestorFinalizacionIntervencion
}
