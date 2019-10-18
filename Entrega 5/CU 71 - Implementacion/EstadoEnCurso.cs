using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace CU71
{
    public class EstadoEnCurso : EstadoIntervencion
    {

        public EstadoEnCurso(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public Boolean abortar(DateTime fecha, Intervencion inter)
        {

            throw new NotImplementedException();
        }

        public Boolean esEnCurso()
        {
            return true;
        }

        public Boolean finalizar(DateTime fecha, Intervencion inter)
        {
            try{
                EstadoIntervencion nuevo = new EstadoFinalizada(fecha);
                inter.anadirEstado(nuevo);
                return true;
            }
            catch(Exception ex){
                //rollback()
                return false;
            }
        }


	}

}//end EstadoEnCurso
