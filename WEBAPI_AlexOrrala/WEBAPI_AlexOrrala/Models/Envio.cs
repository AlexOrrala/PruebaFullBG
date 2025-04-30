using Microsoft.Win32;

namespace WEBAPI_AlexOrrala.Models
{
    public class Envio
    {
        public int Id { get; set; }

        public String origen { get; set; }

        public string destino {  get; set; }
        public String ubicacionActual { get; set; }
        public String EstadoEnvio { get; set; }
        public DateTime FechaInicio {  get; set; }

        public int tiempoEstimado { get; set; }
        public int TarifaId {  get; set; }

        public Tarifas Tarifa { get; set; }

        public ICollection<Viaje> viajes { get; set; }

    }
}
