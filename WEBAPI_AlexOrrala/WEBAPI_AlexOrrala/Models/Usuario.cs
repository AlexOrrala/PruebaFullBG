using System.Collections;

namespace WEBAPI_AlexOrrala.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public string TipoUsuario {  get; set; }

        public ICollection<Viaje> viajes { get; set; }
    }
}
