using Microsoft.EntityFrameworkCore;

namespace LP3_ProjetoFinal.Models;

public class ProjContext : DbContext
{

    public DbSet<MovieTheater> MovieTheaters { get; set; }

    public DbSet<CleaningTime> CleaningTimes { get; set; }

    public DbSet<Product> Products { get; set; }

    public ProjContext(DbContextOptions<ProjContext> options) : base(options)
    {

    }
}