using eventos.API.Services;
using eventos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eventos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursosController : ControllerBase
    {
        private readonly ICursoService _service;
        public CursosController(ICursoService service) 
        {
            _service = service;
        }
        [HttpPost]
        public IActionResult Create([FromBody] Curso curso) 
        {
            _service.Create(curso);
            return Ok(curso);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var listaAlunos = _service.GetAll();

            return Ok(listaAlunos);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var aluno = _service.Get(id);
            if (aluno == null)
            {
                return NotFound("Curso não encontrado");
            }
            return Ok(aluno);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);

            return Ok();
        }
        [HttpPut]
        public IActionResult Update([FromBody] Curso curso)
        {
            _service.Update(curso);
            return Ok(curso);
        }
    }
}
