using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MvcShopping.Models
{
    public class ProductModel
    {
        [Required]
        [DisplayName("商品ID")]
        public string ID { get; set; }
        [Required]
        [DisplayName("商品名")]
        public string Name { get; set; }
        [Required]
        [DisplayName("カテゴリ名")]
        public string Category { get; set; }
        [Required]
        [DisplayName("価格")]
        public int Price { get; set; }
        //商品のリスト
        public IQueryable<TProduct> Products { get; set; }
        //カレントページ
        public int CurrentPage { get; set; }
        //前ページがあるか
        public bool HasPrevPage { get; set; }
        //次ページがあるか
        public bool HasNextPage { get; set; }
    }
    public class ShoppingContext : DbContext {
        public DbSet<TProduct> Products { get; set; }
    }
}

