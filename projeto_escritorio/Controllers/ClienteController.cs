using Microsoft.AspNetCore.Mvc;
using projeto_escritorio.Models;
using System.Runtime.CompilerServices;

namespace projeto_escritorio.Controllers;

[ApiController]
[Route("[controller]")]

public class ClienteController: ControllerBase
{
    private static int id = 0;
    private static List<Cliente> clientes = new List<Cliente>();

    [HttpPost]
    public IActionResult AdicionaCliente([FromBody]Cliente cliente)
    {
        cliente.Id = id++;
        clientes.Add(cliente);
        return CreatedAtAction(nameof(RecuperaClientePorId), new {id = cliente.Id}, cliente);
    }

    [HttpGet]
    public IEnumerable<Cliente> RecuperaClientes([FromQuery]int skip=0, [FromQuery] int take=10)
    {
        return clientes.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaClientePorId(int id)
    {
        var cliente = clientes.FirstOrDefault(cliente => cliente.Id == id);

        if (cliente == null) return NotFound();
        return Ok(cliente);
    }
}
