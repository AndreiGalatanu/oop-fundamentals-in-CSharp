using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class OrderItem :EntityBase
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        /// <summary>
        /// Retrieve Order Item
        /// </summary>
        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }
        /// <summary>
        /// Save the OrderItem
        /// </summary>
        public bool Save(OrderItem order)
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
        public override bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;
            return isValid;
        }

    }
}
