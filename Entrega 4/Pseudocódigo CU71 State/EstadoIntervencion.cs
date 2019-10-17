using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace CU71
{
    public abstract class EstadoIntervencion
    {

        private DateTime fecha;

        public Boolean abortar(DateTime fecha, Intervencion inter)
        {

            throw new NotImplementedException();
        }

        public Boolean cancelar(DateTime fecha, Intervencion inter)
        {

            throw new NotImplementedException();
        }

        public Boolean convocar(DateTime fecha, Intervencion inter)
        {

            throw new NotImplementedException();
        }

        public Boolean esAbortada()
        {

            return false;
        }

        public Boolean esCancelada()
        {

            return false;
        }

        public Boolean esConvocada()
        {

            return false;
        }

        public Boolean esEnCurso()
        {

            return false;
        }

        public Boolean esFinalizada()
        {

            return false;
        }

        public Boolean esFirmada()
        {

            return false;
        }

        public Boolean esPendiente()
        {

            return false;
        }

        public Boolean finalizar(DateTime fecha, Intervencion inter)
        {

            throw new NotImplementedException();
        }

        public Boolean firmar(DateTime fecha, Intervencion inter)
        {

            throw new NotImplementedException();
        }

        public DateTime getFecha()
        {
            return this.fecha;
        }

        public Boolean iniciar(DateTime fecha, Intervencion inter)
        {

            throw new NotImplementedException();
        }

        public Boolean programar(DateTime fecha, Intervencion inter)
        {

            throw new NotImplementedException();
        }
    }//end EstadoIntervencion
}
