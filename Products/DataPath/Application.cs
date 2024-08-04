
using Microsoft.EntityFrameworkCore;
using Products.Models;
namespace Products.DataPath
{
    public class Application:DbContext
    {

        public DbSet<Product>products { get; set; }
        public DbSet<Catogery> catogeries { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);


            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json",true,reloadOnChange:true).Build();

            var connection=builder.GetConnectionString("DefaultString");

            optionsBuilder.UseSqlServer(connection);


        }




    }
}
