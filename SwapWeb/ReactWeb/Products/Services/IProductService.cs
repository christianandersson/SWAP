using SwapWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwapWeb.Products.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
    }
}
