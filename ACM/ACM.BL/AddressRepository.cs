using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {



        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            //Code that retrieves the defined addresses for customer.

            //---------------------------Hardcoded---------
            var addressList = new List<Address>();
            Address address = new Address(1)
            {

                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bag Endsd 2",
                City = "Hobitton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "133242"
            };
            addressList.Add(address);

            address = new Address(2)
            {

                AddressType = 2,
                StreetLine1 = "Green Smile",
                StreetLine2 = "Bag Slug",
                City = "Worky",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "321242"
            };
            addressList.Add(address);
            return addressList;

        }
        /// <summary>
        /// Retrive
        /// </summary>
        public Address Retrieve(int addressId)
        {

            //HardCode

            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bag Endsd 2";
                address.City = "Hobitton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "133242";
            }
            return address;
        }
        /// <summary>
        /// Save
        /// </summary>
        public bool Save(Address address)
        {
            return true;
        }
    }
}
