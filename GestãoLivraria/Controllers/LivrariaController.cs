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

        [HttpGet]
        [ProducesResponseType(typeof(List<RequestDadosLivrariaJson>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult Show()
        {
            var listaDeLivros = new List<RequestDadosLivrariaJson>()
            {
                new RequestDadosLivrariaJson(){Id = 1, Autor = "Shakespere", Genero = "Terror", Preco = 99.90, Quantidade = 5},
                new RequestDadosLivrariaJson(){Id = 2, Autor = "Clarice Lispector", Genero = "Romance", Preco = 59.90, Quantidade = 3},
            }; 
            
            return Ok(listaDeLivros);
        }

        

        
    }
}
