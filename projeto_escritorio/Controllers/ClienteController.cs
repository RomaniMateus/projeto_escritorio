using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using projeto_escritorio.Data;
using projeto_escritorio.Data.Dtos;
using projeto_escritorio.Models;
using System.Runtime.CompilerServices;

namespace projeto_escritorio.Controllers;

[ApiController]
[Route("[controller]")]

public class ClienteController: ControllerBase
{
    private ClienteContext _context;
    private IMapper _mapper;

    public ClienteController(ClienteContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionaCliente([FromBody]CreateClienteDto clienteDto)
    {
        Cliente cliente = _mapper.Map<Cliente>(clienteDto);
        _context.Clientes.Add(cliente);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperaClientePorId), new {id = cliente.Id}, cliente);
    }

    [HttpGet]
    public IEnumerable<Cliente> RecuperaClientes([FromQuery]int skip=0, [FromQuery] int take=10)
    {
        return _context.Clientes.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaClientePorId(int id)
    {
        var cliente = _context.Clientes.FirstOrDefault(cliente => cliente.Id == id);

        if (cliente == null) return NotFound();
        return Ok(cliente);
    }

    [HttpPut("{id}")]
    public IActionResult AtualizaCliente(int id, [FromBody] UpdateClienteDto clienteDto)
    {
        var cliente = _context.Clientes.FirstOrDefault(cliente => cliente.Id.Equals(id));

        if (cliente == null) return NotFound();

        _mapper.Map(clienteDto, cliente);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPatch("{id}")]
    public IActionResult AtualizaClienteParcial(int id, JsonPatchDocument<UpdateClienteDto> patch)
    {
        var cliente = _context.Clientes.FirstOrDefault(cliente => cliente.Id.Equals(id));

        if (cliente == null) return NotFound();

        var clienteParaAtualizar = _mapper.Map<UpdateClienteDto>(cliente);
        patch.ApplyTo(clienteParaAtualizar, ModelState);

        if (!TryValidateModel(clienteParaAtualizar))
        {
            return ValidationProblem(ModelState);
        }

        _mapper.Map(clienteParaAtualizar, cliente);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletaCliente(int id)
    {
        var cliente = _context.Clientes.FirstOrDefault(cliente => cliente.Id.Equals(id));

        if (cliente == null) return NotFound();

        _context.Remove(cliente);
        _context.SaveChanges();

        return NoContent();
    }
}
