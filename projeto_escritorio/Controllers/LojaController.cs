using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using projeto_escritorio.Data;
using projeto_escritorio.Data.Dtos;
using projeto_escritorio.Models;

namespace projeto_escritorio.Controllers;

[ApiController]
[Route("[controller]")]
public class LojaController : ControllerBase
{
    private ClienteContext _context;
    private IMapper _mapper;

    public LojaController(ClienteContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionaLoja([FromBody] CreateLojaDto lojaDto)
    {
        Loja loja = _mapper.Map<Loja>(lojaDto);

        _context.Lojas.Add(loja);
        _context.SaveChanges();
        return CreatedAtActionResult(nameof(RecuperaLojaPorId), new { Id = loja.Id }, lojaDto);
    }

    [HttpGet]
    public IEnumerable<ReadLojaDto> RecuperaLojas()
    {
        return _mapper.Map<List<ReadLojaDto>>(_context.Lojas.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaLojaPorId(int id)
    {
        Loja loja = _context.Lojas.FirstOrDefault(loja => loja.Id == id);

        if(loja == null)
        {
            return NotFound();
        }

        ReadLojaDto lojaDto = _mapper.Map<ReadLojaDto>(loja);

        return Ok(lojaDto);
    }

    [HttpPut("{id}")]
    public IActionResult AtualizaLoja(int id, [FromBody] UpdateLojaDto lojaDto)
    {
        Loja loja = _context.Lojas.FirstOrDefault(loja => loja.Id == id);

        if (loja == null)
            return NotFound();

        _mapper.Map(lojaDto, loja);
        _context.SaveChanges();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletaLoja(int id)
    {
        Loja loja = _context.Lojas.FirstOrDefault(loja => loja.Id == id);

        if(loja == null)
            return NotFound();

        _context.Remove(loja);
        _context.SaveChanges();

        return NoContent();
    }
}
