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
    }
}