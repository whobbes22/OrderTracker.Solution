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
      public ActionResult Create(string vendorName)
      {
        Vendor vend = new Vendor(vendorName,"a");
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

      // new orders

      [HttpPost("/vendor/{vendorId}/orders")]
      public ActionResult Create(int vendorId, string script)
      {
        Dictionary<string,object> model = new Dictionary<string, object> ();
        Vendor foundVend = Vendor.Find(vendorId);
        Order newOrd = new Order("title","price",script);
        List<Order> selectedOrder = foundVend.Orders;
        model.Add("vendor",selectedOrder);
        model.Add("order",foundVend);
        return View("Show",model);
      }
    }
}