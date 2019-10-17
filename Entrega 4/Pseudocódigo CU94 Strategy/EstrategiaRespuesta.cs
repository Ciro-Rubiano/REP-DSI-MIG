using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace CU94
{
	public class EstrategiaRespuesta : IEstrategiaTiempo {

		public string calcularTiempo(Intervecion[] intervenciones){

			return "";
		}

		public boolean esActiva(){
			// devuelve True si la estrategia está activa, false si esta inactiva
		}
		public EstrategiaRespuesta crear(){
			return new EstrategiaRespuesta();
		}

	}//end EstrategiaRespuesta
}
