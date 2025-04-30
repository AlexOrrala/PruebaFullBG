using Microsoft.EntityFrameworkCore;
using WEBAPI_AlexOrrala.Models;
using WEBAPI_AlexOrrala.Models.DTO;

namespace WEBAPI_AlexOrrala.Servicios
{
    public class GeneralServicios
    {
        private readonly ApplicationDbContext _context;

        public GeneralServicios(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Envio> SaveEnvio(EnvioDTO envio)
        {
            Envio envio1 = new Envio();
            envio1.origen = envio.origen;
            envio1.TarifaId = envio.TarifaId;
            envio1.FechaInicio = envio1.FechaInicio;
            envio1.ubicacionActual = envio1.ubicacionActual;
            envio1.EstadoEnvio = envio1.EstadoEnvio;
            envio1.tiempoEstimado = envio1.tiempoEstimado;

            await _context.Envios.AddAsync(envio1);
            await _context.SaveChangesAsync();

            return envio1;
        }

        internal async Task<Tarifas> GetTarifas(int id)
        {
            Tarifas tarifa = await _context.Tarifas.Where( t => t.Id == id).FirstAsync();
            return tarifa;
        }

        internal async Task<Envio> GetEnvios(int id)
        {
            Envio tarifa = await _context.Envios.Where(t => t.Id == id).FirstAsync();
            return tarifa;
        }

        internal async Task<TarifaDTO> SaveTarifa(TarifaDTO value)
        {
            Tarifas tarifa = new Tarifas();
            tarifa.tipoRuta = value.tipoRuta;
            tarifa.tipoCarga = value.tipoCarga;
            tarifa.monto = value.monto;


            await _context.Tarifas.AddAsync(tarifa);
            await _context.SaveChangesAsync();

            return value;

        }
    }
}
