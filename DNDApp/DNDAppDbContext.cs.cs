
    using Microsoft.EntityFrameworkCore;
    using DNDApp.Models;
    using System.Runtime.CompilerServices;


namespace DNDApp
{
    public class DNDAppDbContext : DbContext
    {
        public DbSet<User> Reservations { get; set; }

        public DNDAppDbContext(DbContextOptions<DNDAppDbContext> context) : base(context)
        {

        }
    }
}