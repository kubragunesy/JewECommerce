using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-O1J0TIB\\SQLEXPRESS; database =JewDb; integrated security=true");
          
        }


        public DbSet<Admin> Admins { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<BankCard> BankCards { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<PreOrder> PreOrders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Remand> Remands { get; set; }
        

    }
}
