using Data_Access_Layer_DL_.Models.CategoryModels;
using Data_Access_Layer_DL_.Models.ProductModels;
using Data_Access_Layer_DL_.Models.SellesModels;
using Data_Access_Layer_DL_.Models.UserModels;
using Microsoft.EntityFrameworkCore;

namespace Data_Access_Layer_DL_.ApplicationDbContext
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }

        public DbSet<User>users { get; set; }
        public DbSet<UserCreds> userCreds { get; set; }
        public DbSet<Products>products { get; set; }
        public DbSet<Sells>sells { get; set; }
        public DbSet<Categories>categories { get; set; }

    }
}
