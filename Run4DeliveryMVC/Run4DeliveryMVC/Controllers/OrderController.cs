using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Run4DeliveryMVC.Controllers
{
    public class OrderController : Controller
    {
        //
        // GET: /Order/

        public ActionResult CreateOrder()
        {
            return View();
        }

    }
}
