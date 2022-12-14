using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ICustomerService
    {

        void SaveCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        List<Customer> GetAllCustomers();
        Customer GetById(int id);
    }
}

