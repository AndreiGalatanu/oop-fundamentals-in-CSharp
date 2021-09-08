using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        /// <summary>
        /// Retrieve one customer
        /// </summary>
        public Customer Retrieve(int customerId)
        {
            var c1 = new Customer(customerId);
            if (customerId == 1)
            {
                c1.EmailAddress = "brobva@dda.com";
                c1.FirstName = "Bram";
                c1.LastName = "Joe";
                c1.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return c1;
        }

        /// <summary>
        /// Save the current Customer.
        /// </summary>

        public bool Save(Customer c1)
        {
            return true;
        }


        /// <summary>
        /// Retrieve all Customers
        /// </summary>

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

    }
}
