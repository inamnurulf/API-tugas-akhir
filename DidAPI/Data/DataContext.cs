using DidAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DipApi.Data
{
    public class DataContext : DbContext    
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Mission> Missions { get; set; }
    }
}
