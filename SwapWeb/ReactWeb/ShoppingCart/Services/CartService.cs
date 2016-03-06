using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwapWeb.ShoppingCart.Models;

namespace SwapWeb.ShoppingCart.Services
{
    public class CartService : ICartService
    {
        public Cart GetCart()
        {
            var cart = (Cart)System.Web.HttpContext.Current.Session["cart"];

            if(cart != null)
            {
                return cart;
            }

            cart = new Cart();

            System.Web.HttpContext.Current.Session["cart"] = cart;
            
            return cart;
        }

        public void SaveCart(Cart cart)
        {
            System.Web.HttpContext.Current.Session["cart"] = cart;
        }
    }
}
