using Microsoft.EntityFrameworkCore;
using aba_backend.Models;
using Microsoft.AspNetCore.Authentication;

namespace aba_backend.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Proveedor> Proveedores { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<TicketDetalle> Detalles { get; set; }
    public DbSet<HistorialInventario> HistorialInvetario { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}

