using Microsoft.EntityFrameworkCore;

namespace Demo
{
    //Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;
    //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=mhd;Trusted_Connection=True");
        }
        public DbSet<Student> Students { get; set; }
    }
}
