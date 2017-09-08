using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using logictast.Entities;

namespace logictast.Abstract
{
    public interface ICustomer
    {
        IQueryable<Customer> customer { get; }
        void save(Customer c);
        Customer DeleteA(int Id);
    }
}
