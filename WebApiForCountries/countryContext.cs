using Microsoft.EntityFrameworkCore;

namespace WebApiForCountries
{
    public class countryContext : DbContext
    {
        public countryContext(DbContextOptions options) : base(options) { }
        public DbSet<Countries> countries {get; set;}
    }
}
