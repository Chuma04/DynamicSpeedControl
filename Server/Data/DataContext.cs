global using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DynamicSpeedControl.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<RestrictedAreaEntity> RestrictedAreas { get; set; }
    }
}
