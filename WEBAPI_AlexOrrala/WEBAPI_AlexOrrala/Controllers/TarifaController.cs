using Microsoft.AspNetCore.Mvc;
using WEBAPI_AlexOrrala.Models;
using WEBAPI_AlexOrrala.Models.DTO;
using WEBAPI_AlexOrrala.Servicios;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEBAPI_AlexOrrala.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarifaController : ControllerBase
    {

        private readonly GeneralServicios _generalServicios;
        public TarifaController(GeneralServicios generalServicios)
        {
            _generalServicios = generalServicios;
        }

        // GET api/<TarifaController>/5
        [HttpGet("{id}")]
        public Task<Tarifas> Get(int id)
        {
            return _generalServicios.GetTarifas(id);
        }

        // POST api/<TarifaController>
        [HttpPost]
        public void Post([FromBody] TarifaDTO value)
        {
            _generalServicios.SaveTarifa(value);

        }

    }
}
