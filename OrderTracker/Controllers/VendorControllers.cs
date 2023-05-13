using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;
using System.Collections.Generic;


namespace OrderTracker.Controllers
{
    public class VendorController : Controller
    {

      [HttpGet("/vendor")]
      public ActionResult Index()
      {
        List<Vendor> vend = Vendor.GetAll();
        return View(vend);
      }

      [HttpGet("/vendor/new")]
      public ActionResult New()
      {
        return View();
      }

      [HttpPost("/vendor")]
      public ActionResult Create(string vendorName,string vendorDescription)
      {
        Vendor vend = new Vendor(vendorName,vendorDescription);
        return RedirectToAction("Index");
      }

      [HttpGet("/vendor/{id}")]
      public ActionResult Show(int id)
      {
        Dictionary<string,object> model = new Dictionary<string, object> ();
        Vendor selectedVend = Vendor.Find(id);
        List<Order> selectedOrder = selectedVend.Orders;
        model.Add("vendor",selectedVend);
        model.Add("order",selectedOrder);
        return View(model);
      }

      // new orders creates orders to display within 1 vendor

      [HttpPost("/vendor/{vendorId}/orders")]
      public ActionResult Create(int vendorId,string orderTitle,string orderPrice, string orderDescription)
      {
        Dictionary<string,object> model = new Dictionary<string, object> ();
        Vendor foundVend = Vendor.Find(vendorId);
        Order newOrd = new Order(orderTitle,orderPrice,orderDescription);
        foundVend.AddOrder(newOrd);
        List<Order> selectedOrder = foundVend.Orders;
        
        model.Add("order",selectedOrder);
        model.Add("vendor",foundVend);
        return View("Show",model);
      }
    }
}