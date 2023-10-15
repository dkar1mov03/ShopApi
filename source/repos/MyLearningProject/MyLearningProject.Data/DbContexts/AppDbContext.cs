using Microsoft.EntityFrameworkCore;
using MyLearningProject.Domain.Entities.Users;

namespace MyLearningProject.Data.DbContexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }
    public DbSet<User> Users { get; set; }  
}