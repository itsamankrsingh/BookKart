using BookKartWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BookKartWeb.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }

        public DbSet<Category> Categories { get; set; } //create table in database name of table-> Categories
    }
}
