using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class JewECommerceContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=JewECommerceDb;integrated security=true");
        //}

        public DbSet<Admin> admins { get; set; }
        public DbSet<Adress> adresses { get; set; }
        public DbSet<BankCard> bankCards { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Collection> collections { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Discount> discounts { get; set; }
        public DbSet<PaymentMethod> paymentMethods { get; set; }
        public DbSet<PreOrder> preOrders { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Remand> remands { get; set; }

    }
}
