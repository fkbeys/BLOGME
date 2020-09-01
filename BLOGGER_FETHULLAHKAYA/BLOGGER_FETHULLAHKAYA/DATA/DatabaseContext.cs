using BLOGS.Models;
using Microsoft.EntityFrameworkCore;

namespace BLOGGER_FETHULLAHKAYA.DATA
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
           
        }
        public DbSet<AUTHORS> AUTHORSS { get; set; }
        public DbSet<ARTICLES> ARTICLESS { get; set; }
        
    }
}