using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
    public class VendorController : Controller
    {

      [HttpGet("/vendor")]
      public ActionResult Index()
      {
        return View();
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
        model.Add("Vendor",selectedVend);
        model.Add("order",selectedOrder);
        return View(model);
      }
    }
}