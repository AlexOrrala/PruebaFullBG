namespace WEBAPI_AlexOrrala.Models.DTO
{
    public class EnvioDTO
    {

        public String origen { get; set; }

        public string destino { get; set; }
        public String ubicacionActual { get; set; }
        public String EstadoEnvío { get; set; }
        public DateTime FechaInicio { get; set; }

        public int tiempoEstimado { get; set; }
        public int TarifaId { get; set; }


    }
}
