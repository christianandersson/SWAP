using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using SwapWeb.Products.Services;
using SwapWeb.Products.Models;
using SwapWeb.ShoppingCart.Services;

namespace SwapWeb.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICartService _cartService;

        public ProductsController(IProductService productService, ICartService cartService)
        {
            _productService = productService;
            _cartService = cartService;
        }

        // GET: Products
        [Route("")]
        public ActionResult Index()
        {
            return View(new ProductsViewModel 
            {
                Cart = _cartService.GetCart(),
                Products = _productService.GetAll()
            });
        }
    }
}