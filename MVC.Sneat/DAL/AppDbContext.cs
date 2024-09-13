using Microsoft.EntityFrameworkCore;
using MVC.Sneat.DAL.Entities;

namespace MVC.Sneat.DAL;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Teacher> Teachers { get; set; } = null!;
    public DbSet<Group> Groups { get; set; } = null!;
}
