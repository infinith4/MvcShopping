using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Linq;
using MvcShopping.Models;
using System.Data.Entity;

namespace MvcShopping.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/Test
        public ActionResult Test()
        {
            //web.configから接続文字列を取得
            string cnstr = ConfigurationManager.ConnectionStrings[
               "mvcdbEntities"].ConnectionString; // 		cnstr	"metadata=res://*/Models.DBmodel.csdl|res://*/Models.DBmodel.ssdl|res://*/Models.DBmodel.msl;provider=System.Data.SqlClient;provider connection string=\"data source=.\\sqlexpress;initial catalog=mvcdb;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework\""	string

            mvcdbEntities testmodel = new mvcdbEntities();
            var product = new TProduct(){
                id = "E0003",
                name = "test",
                price = 1000,
                cateid = 1
            };
            IQueryable result1;
            using (var context = new mvcdbEntities())
            {
                context.TProduct.Add(product);
                //context.SaveChanges(); //dbo.TProduct に追加する
                result1 = context.TProduct.Where(c => c.price > 1000);
                //
                foreach (var p in context.TProduct) {
                    Console.WriteLine(p.id + " " + p.name + " " + p.price);

                }
            }
            var result = from p in testmodel.TProduct
                         where p.price > 1000
                         select p;
            //result is IQueryable<TProduct> ??
//            testmodel.TProduct = (Models.TProduct)testmodel.TProduct.Where(c => c.id == "A0001");
            //var id = "A0001";
            // = testmodel.TProduct.Find(id);
            return View(result1);
        }
        public ActionResult Index(int? page)
        {
            //web.configから接続文字列を取得
            string cnstr = ConfigurationManager.ConnectionStrings[
               "mvcdbConnectionString"].ConnectionString;
            DataContext dc = new DataContext(cnstr);
            //商品一覧を取得
            ProductModel model = new ProductModel();
            model.Products = dc.GetTable<TProduct>();
            
            //1ページに表示する
            int max_item = 5;
            //表示中のページ
            int cur_page = page ?? 0;
            int max = dc.GetTable<TProduct>().Count();
            //指定ページの商品数を取得する
            model.Products = (from p in dc.GetTable<TProduct>()
                              select p).Skip(cur_page * max_item).Take(max_item);
            //カレントページの設定
            model.CurrentPage = cur_page;
            //前頁が存在するか
            if (cur_page == 0)
            {
                model.HasPrevPage = false;
            }
            else {
                model.HasPrevPage = true;
            }
            //次頁が存在するか
            if (cur_page * max_item + max_item < max)
            {
                model.HasNextPage = true;
            }
            else {
                model.HasNextPage = false;
            }
            //setting model
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
