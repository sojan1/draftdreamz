
using draftdreamz.Components.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace draftdreamz.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<ContentInfo> ContentDbSet { get; set; }
        public DbSet<ContentType> ContentTypeDbSet { get; set; }
    }
 
}
