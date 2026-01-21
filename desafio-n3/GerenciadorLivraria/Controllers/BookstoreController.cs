using GerenciadorLivraria.Communication.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorLivraria.Controllers;
[Route("[controller]")]
[ApiController]
public class BookstoreController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult RegisterBook([FromBody] RequestRegisterBook request)
    {
        return Created();
    }

    /*
    [HttpGet]
    public IActionResult GetAllBooks()
    {
        return Ok("All books");
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult GetBookById(int id)
    {
        return Ok($"Book by ID: {id}");
    }

    [HttpPut]
    public IActionResult UpdateBook()
    {
        return Ok("Update Book");
    }

    [HttpDelete]
    public IActionResult DeleteBook()
    {
        return Ok("Delete book");
    }*/
}
