using Microsoft.EntityFrameworkCore;

namespace WebApi
{
    public class StandUpContext : DbContext
    {
        public StandUpContext(DbContextOptions<StandUpContext> options) : base(options)
        {

        }
        public DbSet<Presentation> Presentations { get; set; }
        public DbSet<Section> Sections { get; set; }
    }
}
