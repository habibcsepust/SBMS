using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMS.Model;
using SBMS.Repository;

namespace SBMS.BLL
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();
        Customer customer = new Customer();

        public bool AddCustomer(Customer customer)
        {
            return _customerRepository.AddCustomer(customer);
        }

        public List<Customer> DisplayCustomer()
        {
            return _customerRepository.DisplayCustomer();
        }

        public bool IsExistCode(Customer customer)
        {
            return _customerRepository.IsExistCode(customer);
        }

        public bool IsExistContact(Customer customer)
        {
            return _customerRepository.IsExistContact(customer);
        }

        public bool IsExistEmail(Customer customer)
        {
            return _customerRepository.IsExistEmail(customer);
        }

        public bool UpdateCustomer(Customer customer, string loyalty, int id)
        {
            return _customerRepository.UpdateCustomer(customer, loyalty, id);
        }

        public bool DeleteCustomer(int id)
        {
            return _customerRepository.DeleteCustomer(id);
        }

        public List<Customer> SearchCustomer(string criteria)
        {
            return _customerRepository.SearchCustomer(criteria);
        }
    }
}
