using Microsoft.EntityFrameworkCore;
using PeopleApi.Models;

namespace PeopleApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Person> People { get; set; }
}