using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace CU71
{
    public class EstadoFinalizada : EstadoIntervencion
    {

        public EstadoFinalizada(DateTime fecha)
        {
            this.fecha = fecha;
        }

    }
}
