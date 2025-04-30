namespace WEBAPI_AlexOrrala.Models
{
    public class Viaje
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int TiempodeViaje { get; set; }
        public int EnvioId { get; set; }
        public Envio envio { get; set; }

        public int UsuarioId { get; set; }
        public Usuario usuario { get; set; }
        


    }
}
