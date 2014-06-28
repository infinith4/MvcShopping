using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Linq;
using MvcShopping.Models;

namespace MvcShopping.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //web.configから接続文字列を取得
            string cnstr = ConfigurationManager.ConnectionStrings[
               "mvcdbConnectionString"].ConnectionString;
            DataContext dc = new DataContext(cnstr);
            //商品一覧を取得
            ProductModel model = new ProductModel();
            model.Products = dc.GetTable<TProduct>();
            
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
