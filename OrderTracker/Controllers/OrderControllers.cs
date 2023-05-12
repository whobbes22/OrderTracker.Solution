using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;
using System.Collections.Generic;

namespace OrderTracker.Controllers
{
    public class OrderController : Controller
    {

      [HttpGet("/vendor/{vendorId}/orders/new")]
      public ActionResult New(int vendorId)
      {
        Vendor vend = Vendor.Find(vendorId);
        return View(vend);
      }

      [HttpGet("/vendor/{vendorId}/orders/{orderId}")]
      public ActionResult Show(int vendorId, int orderId)
      {
        Vendor vend = Vendor.Find(vendorId);
        Order ord = Order.Find(orderId);
        
        Dictionary<string,object> model = new Dictionary<string, object> ();
        model.Add("Vendor",vend);
        model.Add("order",ord);
        return View(model);
      }
    }
}