using Microsoft.AspNetCore.Mvc;

namespace aba_backend.Controllers;

[ApiController]

[Route("api/[controller]")]

public class UsuarioController : ControllerBase
{
    [HttpGet]
    public IActionResult ObtenerUsuarios()
    {
        var usuarios = new List<string> { "Ana", "Luis", "Carlos" };

        return Ok(usuarios);
    }
}