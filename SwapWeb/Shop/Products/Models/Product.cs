using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwapWeb.Models
{
    public class Product
    {
        public Category Category { get; set; }

        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public string ShortDescription { get; set; }
    }

    public enum Category
    {
        Woman,
        Man
    }
}