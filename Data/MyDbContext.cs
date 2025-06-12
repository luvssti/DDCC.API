using DDCC.API.Model;
using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

namespace DDCC.API.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
           : base(options)
        {
        }

        public DbSet<monthly_data> monthly_data { get; set; } 
    }


}
