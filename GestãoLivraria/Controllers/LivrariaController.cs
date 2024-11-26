using GestãoLivraria.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestãoLivraria.Controllers
{
    
    public class LivrariaController : LivrariaBaseController
    {

        [HttpPost]
        [ProducesResponseType(typeof(RequestDadosLivrariaJson), StatusCodes.Status201Created)]
        public IActionResult Create([FromBody]RequestDadosLivrariaJson request)
        {
            var livro = new RequestDadosLivrariaJson()
            {
                Id = request.Id,
                Autor = request.Autor,
                Genero = request.Genero,
                Preco = request.Preco,
                Quantidade = request.Quantidade
            };
            
            return Ok(livro);
        }
    }
}
