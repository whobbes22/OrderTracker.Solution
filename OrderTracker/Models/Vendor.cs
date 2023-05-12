using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vendor
  {

    /*
    Properties to include:
    name,description of vendor,a list of orders, anything else
    */

    public string Name {get;set;}
    public string Description {get; set;}
    public int Id {get;}
    private static List<Vendor> _instances = new List<Vendor> {};
    
    public List<Order> Orders {get;set;}
    public Vendor(string name, string script)
    {
      Description = script;
      Name = name;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }


    // Static functions
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }
    
    // Non static functions

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
  
 }

