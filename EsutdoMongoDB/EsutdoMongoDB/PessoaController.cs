using Microsoft.AspNetCore.Mvc;

namespace EsutdoMongoDB
{
    [ApiController]
    [Route("[Controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaService _service;

        public PessoaController(IPessoaService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult InsertPessoa([FromBody] Pessoa pessoa)
        {
            if (pessoa is null)
                return BadRequest();

            return Ok(_service.InsertService(pessoa));
        }

        [HttpGet("Buscar/{nome}")]
        public IActionResult PesquisaPessoaByName([FromRoute]string nome) 
        {
           return Ok(_service.GetService(nome));
        }

        [HttpDelete("Deletar/{id}")]
        public IActionResult DeletarPessoaById([FromRoute] string id) 
        {
            _service.DeleteService(id);
            return Ok();
        }

    }
}
