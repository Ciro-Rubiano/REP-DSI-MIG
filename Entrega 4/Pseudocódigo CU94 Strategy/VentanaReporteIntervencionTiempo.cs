using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace CU94
{
	public class VentanaReporteIntervencionTiempo {

		private int botonBusqueda;
		private int botonConfirmacion;
		private int grillaGravedades;
		private int grillaSiniestros;

		public void mostrarEstrategiasActivas(IEstrategiaTiempo[] estrategias){
			foreach(IEstrategiaTiempo strat in estrategias){
				//mostrar estrategia
			}
		}

		public void seleccionEstrategiaTiempo(int numeroEstrategia){
			gestorReporteIntervencionTiempo.seleccionEstrategiaTiempo(numeroEstrategia);
		}

	}//end VentanaReporteIntervencionTiempo	
}
