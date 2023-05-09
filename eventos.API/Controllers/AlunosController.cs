using eventos.API.Services;
using eventos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eventos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
        private readonly IAlunoService _service;

        public AlunosController(IAlunoService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var listaAlunos = _service.GetAll();
            
            return Ok(listaAlunos);
        }
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var aluno = _service.Get(id);
            if(aluno == null)
            {
                return NotFound("Aluno não encontrado");
            }
            return Ok(aluno);
        }
        [HttpPost]
        public  IActionResult Create([FromBody] Aluno aluno)
        {
            _service.Create(aluno);
            return Ok(aluno);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            _service.Delete(id);

            return Ok();
        }
    }
}
