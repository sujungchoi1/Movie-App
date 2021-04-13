using Microsoft.EntityFrameworkCore;

namespace MovieApp.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}
        public DbSet<User> Users {get;set;}
        public DbSet<Movie> Movies {get;set;}
        public DbSet<Result> Results {get;set;}
        public DbSet<Like> Likes  {get;set;}
        public DbSet<Watch> Watches {get;set;}
    }
}