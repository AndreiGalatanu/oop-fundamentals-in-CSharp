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


            return product;

        }
        /// <summary>
        /// Save the product
        /// </summary>
        public bool Save(Product product)
        {
            return true;
        }



    }
}
