using Microsoft.EntityFrameworkCore;
using BlaCrudWeb.Shared.Models;

namespace BlaCrudWeb.Server.AppContext
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Produto> Produtos { get; set; }
  }
}