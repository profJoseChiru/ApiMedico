using ApiMedico.Contexts;
using ApiMedico.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiMedico.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ListadoMedicoController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;

        public ListadoMedicoController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<ListadoMedico>>> GetListadoMedico()
        {
            return await applicationDbContext.ListadoMedicos.ToListAsync();
        }

        [HttpGet("{nombre}")]
        public async Task<ActionResult<List<ListadoMedico>>> GetMedicoNombre(string nombre)
        {
            if (String.IsNullOrWhiteSpace(nombre))
            {
                return BadRequest("El nombre no puede estar vacio");
            }
            var resultados = await applicationDbContext.ListadoMedicos.Where(m => m.nombre.ToLower().Contains(nombre.ToLower())).ToListAsync();
            if (!resultados.Any())
            {
                return NotFound("No se encontro médicos con ese nombre ");
            }
            return Ok(resultados);
        }
    }
}
