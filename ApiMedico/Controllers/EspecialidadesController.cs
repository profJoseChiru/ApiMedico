using ApiMedico.Contexts;
using ApiMedico.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiMedico.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EspecialidadesController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;

        public EspecialidadesController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        [HttpGet]
        public async Task<ActionResult<List<Especialidades>>> GetEspecialidades()
        {
            return await applicationDbContext.Especialidades.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Especialidades>> GetEspecialidades(int id)
        {
            var especialidad = await applicationDbContext.Especialidades.FindAsync(id);
            if (especialidad == null)
            {
                return NotFound();
            }
            return Ok(especialidad);
        }
    }
}
