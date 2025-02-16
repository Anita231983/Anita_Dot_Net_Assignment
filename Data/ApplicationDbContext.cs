using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Anita_Dot_Net_Assignment.Models;

namespace Anita_Dot_Net_Assignment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Anita_Dot_Net_Assignment.Models.Book> Book { get; set; } = default!;
        public DbSet<Anita_Dot_Net_Assignment.Models.Student> Student { get; set; } = default!;
    }
}
