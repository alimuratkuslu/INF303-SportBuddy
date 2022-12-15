using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class CustomerRepository : ICustomerDal
    {

        private readonly Context _context;

        public CustomerRepository(Context context)
        {
            _context = context;
        }

        public void DeleteCustomer(Customer customer)
        {
            _context.Remove(customer);
            _context.SaveChanges();
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.customer.ToList();
        }

        public Customer GetCustomerById(int id)
        {
            return _context.customer.Find(id);  
        }

        public void SaveCustomer(Customer customer)
        {
            _context.Add(customer);
            _context.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            _context.Update(customer);
            _context.SaveChanges();
        }
    }
}

