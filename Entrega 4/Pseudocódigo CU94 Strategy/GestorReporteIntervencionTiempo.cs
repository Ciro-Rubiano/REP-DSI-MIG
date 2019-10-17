using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace CU94
{
	public class GestorReporteIntervencionTiempo {

		private IEstrategiaTiempo estrategiaSeleccionada;
		private DateTime fechaDesdeSeleccionada;
		private DateTime fechaHastaSeleccionada;
		private Gravedad[] gravedadesSeleccionadas;
		private Sesion sesionActual;
		private TiposSiniestro[] tiposDeSiniestroSeleccionados;
		private VentanaReporteIntervencionTiempo ventanaReporteIntervencionTiempo;
		private VentanaVisualizacionReporte ventanaVisualizacion;
		private IEstrategiaTiempo[] estrategias;
		private Intervencion[] intervencionesFiltradas;


		public void agregarEstrategia(IEstrategiaTiempo estrategia){
			this.estrategiaSeleccionada = estrategia;
		}

		public void buscarFormaDeVisualizacion(){
			// Busca todas las formas de visualizacion registradas para enviarselas al metodo
			// solicitarFormaVisualcion() de la ventanaReporteIntervencionTiempo
		}

		public void buscarIntervencionesConFiltros(){
			// Anteriormente el gestor filtró segun gravedad, tipo de siniestro y
			// rango temporal (No se escribe código de esto por simplicidad)
			List<IEstrategiaTiempo> estrategiasActivas = new List<IEstrategiaTiempo>();
			for (IEstrategiaTiempo strat in estrategias){
				if(strat.esActiva())
				{
					estrategiasActivas.Add();
				}
			}
			IEstrategiaTiempo[] arrayEstrategias = estrategiasActivas.ToArray()
			ventanaReporteIntervencionTiempo.mostrarEstrategiasActivas(arrayEstrategias);

		}

		public boolean controlarValidezFechas(){

			return null;
		}

		public void crearEstrategia(int numeroEstrategia){
			IEstrategiaTiempo seleccionada;
			switch(numeroEstrategia)
			{
				case 1:
					seleccionada = new EstrategiaCierre();
					break;
				case 2: //esta sería la modelada en nuestra situación
					seleccionada = new EstrategiaDuracion();  
					break;
				case 3:
					seleccionada = new EstrategiaRespuesta();
					break;
			}
			this.agregarEstrategia(seleccionada);
		}

		public void seleccionEstrategiaTiempo(int numeroEstrategia){
			this.crearEstrategia(numeroEstrategia);
			estrategiaSeleccionada.calcularTiempo(intervencionesFiltradas);
		}

	}//end GestorReporteIntervencionTiempo
}
