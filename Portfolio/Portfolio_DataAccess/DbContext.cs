using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Portfolio_Entities;

namespace Portfolio_DataAccess;

public class Context : IdentityDbContext<User>
{
    public Context(DbContextOptions<Context> options): base(options) {}
    
    public DbSet<Request> Requests { get; set; }
}