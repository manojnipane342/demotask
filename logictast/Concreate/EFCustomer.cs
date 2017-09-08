using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using logictast.Abstract;
using logictast.Entities;
using logictast.Concreate;
using System.Data;

namespace logictast.Concreate
{
    public class EFCustomer : ICustomer
    {
        Context context = new Context();
        public IQueryable<Customer> customer
        {
            get
            {
                return context.Customer;
            }
        }
        public void save(Customer c)
        {
            if (c.c_id == 0)
            {
                context.Entry(c).State = EntityState.Added;
            }
            else
            {
                var db = context.Customer.FirstOrDefault(s => s.c_id == c.c_id);
                db.c_id = c.c_id;
                db.c_name = c.c_name;
                db.c_mobile = c.c_mobile;
                db.c_email = c.c_email;
                db.c_gender = c.c_gender;
                db.c_age = c.c_age;
            }
            context.SaveChanges();
        }
        public Customer DeleteA(int id)
        {
            var db = context.Customer.Find(id);
            if (db != null)
            {
                context.Customer.Remove(db);
                context.SaveChanges();
            }
            return db;
        }
    }
}
