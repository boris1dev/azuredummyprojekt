using Microsoft.EntityFrameworkCore;

namespace azure_boris_erste_web_app.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Person> Persons { get; set; }
}