using Microsoft.EntityFrameworkCore;

namespace pertiwiApi.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext (DbContextOptions<MyDbContext> options) : base(options) 
        { 
        
        }

        public DbSet <tbl_users> tbl_users { get; set; }

        public DbSet <tbl_barang> tbl_barang {  get; set; }


    }
}
