using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject
{
    public class IntroDbContext : DbContext
    {
        public IntroDbContext() : base()  //default constructor for my class : inheriting the db context constructor
        { }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

    }
}
    
