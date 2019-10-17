using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace CU94
{
	public class EstrategiaDuracion : IEstrategiaTiempo {

		private Intervencion[] intervencionesFinalizadas;
		private List<String[]> datosIntervenciones;
		private Double promedioDuracion;

		public float calcularPromedioDuracion(){
			Double suma = 0;
			foreach (String[] datos in datosIntervenciones)
			{
				suma += Convert.ToDouble(datos[0])
			}
			return suma/(datosIntervenciones.Count);
		}

		public string calcularTiempo(Intervencion[] intervenciones){
			this.filtrarFinalizadas(intervenciones);

			this.procesarIntervencionesFinalizadas(intervenciones);

			promedioDuracion = this.calcularPromedioDuracion();

			return datosIntervenciones.ToString();
		}

		public int calcularTiempoDeIntervencion(Intervencion intervencion){
			DateTime fechaFinalizacion = intervencion.getFechaFinalizacion();
			DateTime fechaEnCurso = intervencion.getFechaEnCurso();
			return fechaFinalizacion - fechaEnCurso;
		}

		public boolean esActiva(){
			// devuelve True si la estrategia está activa, false si esta inactiva
		}

		public void filtrarFinalizadas(Intervencion[] intervenciones){
			foreach (Intervencion inter in intervenciones)
			{
				if !(inter.esFinalizada())
				{
					intervenciones.delete(inter);
				}
			}
		}

		public void procesarIntervencionesFinalizadas(Intervencion[] intervencionesFinalizadas){
			datosIntervenciones = new List<String[]>;
			foreach (Intervencion inter in intervencionesFinalizadas)
			{
				String tiempo = this.calcularTiempoDeIntervencion(inter).ToString();
				String resumen = inter.getResumenTrabajo();
				String datosEncargado = inter.obtenerDatosDeEncargado();
				String cantDotaciones = inter.contarDotaciones();
				datosIntervenciones.Add(new String[] {tiempo, resumen, datosEncargado, cantDotaciones});
			}
		}

		public EstrategiaDuracion crear(){
			return new EstrategiaDuracion();
		}

	}//end EstrategiaDuracion
}
