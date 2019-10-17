using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CU94
{
	public interface IEstrategiaTiempo  {

		string calcularTiempo(Intervecion[] intervenciones);

		void crear();

		boolean esActiva();
	}//end IEstrategiaTiempo	
}

