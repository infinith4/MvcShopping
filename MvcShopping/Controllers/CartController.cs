using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcShopping.Models;

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
            if (model == null) {
                model = new CartModel();
            }
            return View(model);
        }

    }
}
