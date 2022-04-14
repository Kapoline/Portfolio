using Microsoft.EntityFrameworkCore;
using Portfolio_Entities;

namespace Portfolio_DataAccess;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options): base(options) {}
    
    public DbSet<Request> Requests { get; set; }
}