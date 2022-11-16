using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaAxa.Data;
using PruebaAxa.Models;

namespace PruebaAxa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolizaController : ControllerBase
    {
        private readonly DataContext _context;

        public PolizaController(DataContext context)
        {
            _context = context;
        }
        //Método para listar la la información de la póliza, consultando la placa
        //[Authorize]
        [HttpGet("Listar/{placa}")]
        public async Task<IActionResult> GetPoliza(string placa)
        {
            return Ok(await Task.Run(() => new SPPoliza().Listar(placa)));
        }

        //Método para  mostrar si se puede o no vender la poliza segun la fecha de vencimiento, consultando la placa
        //[Authorize]
        [HttpGet("Vencimiento/{placa}")]
        public async Task<IActionResult> GetVencimiento(string placa)
        {
            return Ok(await Task.Run(() => new SPPoliza().FechaVencimiento(placa)));
        }


    }
}
