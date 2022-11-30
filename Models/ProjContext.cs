using Microsoft.EntityFrameworkCore;

namespace LP3_ProjetoFinal.Models;

public class ProjContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    
    public DbSet<MovieTheater> MovieTheaters { get; set; }

    public DbSet<Film> Films { get; set; }

    public DbSet<CleaningTime> CleaningTimes { get; set; }

    public DbSet<Store> Stores { get; set; }

    public DbSet<Product> Products { get; set; }

    public ProjContext(DbContextOptions<ProjContext> options) : base(options)
    {

    }
}