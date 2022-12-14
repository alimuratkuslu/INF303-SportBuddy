using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {

        private readonly ICustomerDal customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            this.customerDal = customerDal;
        }

        public void DeleteCustomer(Customer customer)
        {
            customerDal.DeleteCustomer(customer);
        }

        public List<Customer> GetAllCustomers()
        {
            return customerDal.GetAllCustomers();
        }

        public Customer GetById(int id)
        {
            return customerDal.GetCustomerById(id);
        }

        public void SaveCustomer(Customer customer)
        {
            customerDal.SaveCustomer(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            customerDal.UpdateCustomer(customer);
        }
    }
}

