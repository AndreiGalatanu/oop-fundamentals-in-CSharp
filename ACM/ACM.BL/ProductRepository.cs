using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ACM.BL
{
    public class ProductRepository
    {


        /// <summary>
        /// Retrieve one Product
        /// </summary>
        public Product Retrive(int productId)
        {
            var product = new Product(productId);

            // Temporary hard-coded
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted size set of 4 bright ";
                product.CurrentPrice = 15.23M;
            }

            Object myObj = new Object();
            Console.WriteLine($"Object:{myObj.ToString()}");
            Console.WriteLine($"Product:{product.ToString()}");
            return product;

        }
        /// <summary>
        /// Save the product
        /// </summary>
        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChages)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
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
