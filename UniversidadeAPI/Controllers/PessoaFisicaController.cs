using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversidadeAPI.Data;
using UniversidadeAPI.Models;

namespace UniversidadeAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PessoaFisicaController : ControllerBase
{

private readonly UniversidadeContext _context;

public PessoaFisicaController(UniversidadeContext context)
{
_context = context;
}

[HttpGet]
public async Task<IEnumerable<PessoaFisica>> Get()
{
return await _context.PessoasFisicas.ToListAsync();
}

[HttpPost]
public async Task<IActionResult> Post(PessoaFisica pessoa)
{
_context.PessoasFisicas.Add(pessoa);
await _context.SaveChangesAsync();
return Ok(pessoa);
}

[HttpDelete("{id}")]
public async Task<IActionResult> Delete(int id)
{
var pessoa = await _context.PessoasFisicas.FindAsync(id);
if(pessoa == null)
return NotFound();

_context.PessoasFisicas.Remove(pessoa);
await _context.SaveChangesAsync();

return Ok();
}

}