using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcShopping.Models
{
    public class ProductModel
    {
        //商品のリスト
        public IQueryable<TProduct> Products { get; set; }
        //カレントページ
        public int CurrentPage { get; set; }
        //前ページがあるか
        public bool HasPrevPage { get; set; }
        //次ページがあるか
        public bool HasNextPage { get; set; }
    }
}