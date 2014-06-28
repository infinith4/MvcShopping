using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcShopping.Models
{
    public class ProductModel
    {
        public IQueryable<TProduct> Products { get; set; }
    }
}