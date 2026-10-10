using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentApplicationDemo.Models;

namespace StudentApplicationDemo.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {

        public DbSet<Student> Students { get; set; } = default!;
    }

}
