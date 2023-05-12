using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderTracker.Models;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests 
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order cake = new Order("title","a");
      Assert.AreEqual(typeof(Order), cake.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "a good cake";
      Order ord = new Order("1","a",description);
      string result = ord.Description;

      Assert.AreEqual(description, result);
    }
   
    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "Cake1";
      Order ord = new Order("1",title,"description");
      string result = ord.Title;

      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_String()
    {
      string price = "10.1";
      Order ord = new Order(price,"title","description");
      string result = ord.Price;

      Assert.AreEqual(price, result);
    }
  }
}