using Microsoft.AspNetCore.Mvc;
using WEBAPI_AlexOrrala.Models;
using WEBAPI_AlexOrrala.Models.DTO;
using WEBAPI_AlexOrrala.Servicios;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEBAPI_AlexOrrala.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnvioController : ControllerBase
    {

        private readonly GeneralServicios _generalServicios;
        public EnvioController( GeneralServicios generalServicios)
        {
            _generalServicios = generalServicios;
        }


        // POST api/<Envio>
        [HttpPost]
        public void Post([FromBody] EnvioDTO value)
        {
            _generalServicios.SaveEnvio(value);
        }

        //GET api/<Envio>/5
        [HttpGet("{id}")]
        public Task<Envio> GetId(int id)
        {
            return _generalServicios.GetEnvios(id);
        }
    }
}
