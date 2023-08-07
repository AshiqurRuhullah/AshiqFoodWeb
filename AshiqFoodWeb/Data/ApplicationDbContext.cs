using AshiqFoodWeb.Model;
using Microsoft.EntityFrameworkCore;

namespace AshiqFoodWeb.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected ApplicationDbContext()
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
