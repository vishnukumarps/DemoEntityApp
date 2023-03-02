using DemoEntityApp.Model;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace DemoEntityApp.DbContext2;

public class DemoDbContext : DbContext
{

    public DbSet<Student> Students { get; set; }
    public DbSet<Address> Address { get; set; }
    public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options)
    {
    }
}



