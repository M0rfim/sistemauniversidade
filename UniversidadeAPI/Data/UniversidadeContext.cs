using Microsoft.EntityFrameworkCore;
using UniversidadeAPI.Models;

namespace UniversidadeAPI.Data;

public class UniversidadeContext : DbContext
{
public UniversidadeContext(DbContextOptions<UniversidadeContext> options) : base(options)
{
}

public DbSet<PessoaFisica> PessoasFisicas { get; set; }
}