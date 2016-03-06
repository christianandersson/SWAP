using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SwapWeb.ShoppingCart.Models;
using SwapWeb.Models;

namespace SwapWeb.Products.Models
{
    public class ProductsViewModel
    {
        public Cart Cart { get; set; }

        public IEnumerable<Product> Products { get; set; }
   } 
}