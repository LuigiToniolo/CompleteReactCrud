using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Models
{
    public class DonationDBContext : DbContext
    {
        public DonationDBContext(DbContextOptions<DonationDBContext> options) : base(options)
        {
            
        }
        public DbSet<WebApi.Models.DCandidate> DCandidate { get; set; }

        public DbSet<DCandidate> DCandidates { get; set; }
    }
}