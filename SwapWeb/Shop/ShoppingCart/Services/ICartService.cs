using SwapWeb.ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapWeb.ShoppingCart.Services
{
    public interface ICartService
    {
        Cart GetCart();
        void SaveCart(Cart cart);
    }
}
