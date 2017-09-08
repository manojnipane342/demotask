using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using logictast.Entities;

namespace logictast.Concreate
{
    public class Context : DbContext
    {
        public Context() : base("CustomerContext") { }
        public DbSet<Customer> Customer { get; set; }
    }
}
