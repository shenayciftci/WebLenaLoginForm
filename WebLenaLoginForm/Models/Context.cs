using Microsoft.EntityFrameworkCore;

namespace WebLenaLoginForm.Models
{
    public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-CRSBTVQ\\SQLEXPRESS; database=LenaLoginForm; integrated security=true");
        }
        public DbSet<Form> Forms { get; set; }
        public DbSet<Login> Logins { get; set; }
    }
}
