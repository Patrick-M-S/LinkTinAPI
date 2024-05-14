using Microsoft.EntityFrameworkCore;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public DbSet<UserModel> UserRegister { get; set; }
    public DbSet<ProductModel> ProductRegister { get; set; }


}
