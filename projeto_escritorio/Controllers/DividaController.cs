using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using projeto_escritorio.Data;
using projeto_escritorio.Data.Dtos;
using projeto_escritorio.Models;

namespace projeto_escritorio.Controllers;

[ApiController]
[Route("[controller]")]

public class DividaController : ControllerBase
{
    private ClienteContext _context;
    private IMapper _mapper;

    public DividaController(ClienteContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionaDivida([FromBody] CreateDividaDto dividaDto)
    {
        Divida divida = _mapper.Map<Divida>(dividaDto);
        _context.Dividas.Add(divida);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperaDividaPorId), new { id = divida.Id }, divida);
    }

    [HttpGet]
    public IEnumerable<ReadDividaDto> RecuperaDividas([FromQuery] int skip = 0, [FromQuery] int take = 10)
    {
        return _mapper.Map<List<ReadDividaDto>>(_context.Dividas.Skip(skip).Take(take));
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaDividaPorId(int id)
    {
        var divida = _context.Dividas.FirstOrDefault(divida => divida.Id == id);

        if (divida == null) return NotFound();

        var dividaDto = _mapper.Map<ReadDividaDto>(divida);
        return Ok(dividaDto);
    }
}
