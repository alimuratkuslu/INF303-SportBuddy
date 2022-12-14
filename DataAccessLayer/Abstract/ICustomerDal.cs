using System;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface ICustomerDal
    {

        List<Customer> GetAllCustomers();
        void SaveCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        Customer GetCustomerById(int id);
    }
}

