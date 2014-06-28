using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcShopping.Models
{
    public class CartModel
    {
        public List<CartItem> Items;
        public CartModel() {
            this.Items = new List<CartItem>();
        }
    }
    //カートの商品クラス
    public class CartItem {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
    }
}