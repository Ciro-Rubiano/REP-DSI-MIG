using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace CU94
{
	public class EstrategiaCierre : IEstrategiaTiempo {

		public string calcularTiempo(Intervecion[] intervenciones){

			throw new NotImplementedException();
		}

		public boolean esActiva(){
			// devuelve True si la estrategia está activa, false si esta inactiva
		}

		public EstrategiaCierre crear(){
			return new EstrategiaCierre();
		}

	}//end EstrategiaCierre
}
