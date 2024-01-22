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
    public void AdicionaCliente([FromBody]Cliente cliente)
    {
        cliente.Id = id++;
        clientes.Add(cliente);
        Console.WriteLine(cliente.Nome);
        Console.WriteLine(cliente.Endereco);
    }

    [HttpGet]
    public IEnumerable<Cliente> RecuperaClientes()
    {
        return clientes;
    }

    [HttpGet("{id}")]
    public Cliente? RecuperaClientePorId(int id)
    {
        return clientes.FirstOrDefault(cliente => cliente.Id == id);
    }
}
