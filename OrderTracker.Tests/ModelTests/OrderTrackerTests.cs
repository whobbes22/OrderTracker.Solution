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
      Vendor joe = new Vendor("joe","hi");
      Assert.AreEqual(typeof(Vendor), joe.GetType());
    }

    
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "a nice place";
      Vendor ven = new Vendor("joe",description);
      string result = ven.Description;

      //Assert
      Assert.AreEqual(description, result);
    }
    
    [TestMethod]
    public void GetName_ReturnName_String()
    {
      string name = "joe";
      Vendor ven = new Vendor(name,"somewhere nice");
      string result = ven.Name;

      //Assert
      Assert.AreEqual(name, result);
    }
   
  }
}