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
      Order cake = new Order();
      Assert.AreEqual(typeof(Order), cake.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "a good cake";
      Order ord = new Order(description);
      string result = ord.Description;

      Assert.AreEqual(description, result);
    }
   
  }
}