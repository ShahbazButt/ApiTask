using System.Collections.Generic;

namespace Apitask.Server
{
    public class DbContext
{
    public DbContext(DbContextOptions<DbContext> options) : base(options) { }

    public DbSet<DbContext> YourModels { get; set; }
}
}
// Startup.cs

