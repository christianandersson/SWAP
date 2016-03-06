using SwapWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwapWeb.ShoppingCart.Models
{
    public class CartItem
    {
        public Product Product { get; set; }

        public int Quantity { get; set; }
    }
}