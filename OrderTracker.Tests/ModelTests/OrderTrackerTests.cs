using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderTracker.Models;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests 
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor joe = new Vendor();
      Assert.AreEqual(typeof(Vendor), joe.GetType());
    }
   
  }
}