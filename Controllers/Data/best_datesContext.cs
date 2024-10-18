
using Microsoft.EntityFrameworkCore;
using Models.UserProfile;

public class best_datesContext : DbContext
{

    public best_datesContext(DbContextOptions<best_datesContext> options) : base(options)
    {
    }

    public DbSet<UserProfile> userProfiles => Set<UserProfile>();
}