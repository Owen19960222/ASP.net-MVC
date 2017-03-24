using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Controllers
{
    public class OrderController
    {
        //
        //GET: /Order/

        public ActionResult Index()
        {
            Models.OrderService orderService = new Models.OrderService();
            var order = orderService.GetOrderById("111");
            ViewBag.CustId = order.CustId;
            ViewBag.CustName = order.CustName;
            return View();
        }
    }
}