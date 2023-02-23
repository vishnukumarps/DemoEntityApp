using DemoEntityApp.Model;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace DemoEntityApp.DbContext2;

public class DemoDbContext : DbContext
{

    public DbSet<Student> Students { get; set; }
    public DbSet<Address> Address { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {


        var path = "Server=localhost\\SQLEXPRESS;Database=ZDB_TEST2;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true";

        optionsBuilder.UseSqlServer(path);
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {



        base.OnModelCreating(modelBuilder);
    }
}



