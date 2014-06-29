using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcShopping.Models;
using System.Data.Linq;
using System.Configuration;


namespace MvcShopping.Controllers
{
    public class CartController : Controller
    {
        //
        // GET: /Cart/

        public ActionResult Index()
        {
            //display session content
            CartModel model = Session["Cart"] as CartModel;
            if (model == null)
            {
                model = new CartModel();
            }
            return View(model);
        }
        // GET: /Cart/AddItem
        [Authorize]
        public ActionResult AddItem(string id, int? count)
        {
            //display session content
            CartModel model = Session["Cart"] as CartModel;
            if (model == null)
            {
                model = new CartModel();
            }
            string cnstr = ConfigurationManager.ConnectionStrings[
               "mvcdbConnectionString"].ConnectionString;
            DataContext dc = new DataContext(cnstr);
            //Console.ReadLine(dc);
            //id = "A0001";
            var product = (from t in dc.GetTable<TProduct>()
                           where t.id == id
                           select t).Single<TProduct>();
            CartItem item = new CartItem();
            item.ID = id;
            item.Name = product.name;
            item.Price = product.price;
            item.Count = count ?? 1;
            //モデルに追加する
            model.Items.Add(item);
            //save session
            Session["Cart"] = model;
            //カートのページを表示する
            
            return RedirectToAction("Index");
        }

    }
}
