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
            var customer = new Customer(customerId);
            if (customerId == 1)
            {
                customer.EmailAddress = "brobva@dda.com";
                customer.FirstName = "Bram";
                customer.LastName = "Joe";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        /// <summary>
        /// Save the current Customer.
        /// </summary>

        /// <summary>
        /// Save the product
        /// </summary>
        public bool Save(Customer customer)
        {
            var success = true;
            if (customer.HasChages)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
                    {
                        //Call an insert Stored Procedure
                    }
                    else
                    {
                        //Call  an Update Stored Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;

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
