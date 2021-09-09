using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve Order
        /// </summary>
        public Order Retrieve(int orderId)
        {

            Order order = new Order(orderId);

            //Hard coded
            if (orderId == 0)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                    new TimeSpan(7, 0, 0));
            }

            return order;
        }

        /// <summary>
        /// Save Order
        /// </summary>
        public bool Save(Order order)
        {

            var success = true;
            if (order.HasChages)
            {
                if (order.IsValid)
                {
                    if (order.IsNew)
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
    }
}

