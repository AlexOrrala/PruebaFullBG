using Microsoft.Win32;

namespace WEBAPI_AlexOrrala.Models
{
    public class Tarifas
    {

        public int Id { get; set; }
        public string tipoRuta { get; set; }
        public string tipoCarga { get; set; }
        public float monto { get; set; }

        public ICollection<Envio> Envios { get; set; }

    }
}
