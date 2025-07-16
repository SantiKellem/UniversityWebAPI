using Microsoft.AspNetCore.Mvc;
using Domain.Model;
using Domain.Services;
using DTOs;

namespace Controllers
{
    [ApiController]
    [Route("api/alumno")]
    public class AlumnoController : ControllerBase
    {
        private readonly AlumnoService alumnoService;

        public AlumnoController(AlumnoService alumnoService)
        {
            this.alumnoService = alumnoService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Alumno>> GetAll()
        {
            var alumnos = alumnoService.getAll();
            return Ok(alumnos);
        }

        [HttpGet("{id}")]
        public ActionResult<Alumno> GetById(int id)
        {
            var alumno = alumnoService.getById(id);
            if (alumno is null) return NotFound();

            return Ok(alumno);
        }

        [HttpPost]
        public ActionResult<Alumno> CreateAlumno([FromBody] AlumnoDTO alumno)
        {
            var newAlumno = alumnoService.createAlumno(alumno);
            return CreatedAtAction(nameof(GetById), new { id = newAlumno.Id }, newAlumno);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateAlumno(int id, [FromBody] AlumnoDTO alumno)
        {
            var updatedAlumno = alumnoService.updateAlumno(id, alumno);
            return updatedAlumno is not null ? Ok(updatedAlumno) : NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteAlumno(int id)
        {
            var deleted = alumnoService.deleteAlumno(id);
            return deleted ? NoContent() : NotFound();
        }
    }
}
