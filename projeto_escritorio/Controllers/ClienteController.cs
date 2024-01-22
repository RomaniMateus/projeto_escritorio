using Microsoft.AspNetCore.Mvc;
using projeto_escritorio.Models;
using System.Runtime.CompilerServices;

namespace projeto_escritorio.Controllers;

[ApiController]
[Route("[controller]")]

public class ClienteController: ControllerBase
{
    private static List<Cliente> clientes = new List<Cliente>();

    [HttpPost]
    public void AdicionaCliente([FromBody]Cliente cliente)
    {
        clientes.Add(cliente);
        Console.WriteLine(cliente.Nome);
        Console.WriteLine(cliente.Endereco);
    }
}
