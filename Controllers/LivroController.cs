using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MinhaPrimeiraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult criarLivro([FromBody] Livro livro)
        {
            return Created();
        }
        [HttpGet]
        [Route("{id}/{nome}")]
        [ProducesResponseType(typeof(Livro), StatusCodes.Status200OK)]
        public IActionResult consultarLivros(int id, string nome)
        {
            Livro livro = new Livro();
            return Ok(livro);
        }
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult atualizarLivro([FromBody] Livro livro)
        {
            return NoContent();
        }
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult apagarLivro([FromBody] int id)
        {
            return NoContent();
        }
    }
}
