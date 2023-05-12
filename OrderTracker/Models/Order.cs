using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {

    /*
    Properties to include:
    title, the description, the price, the date, other properties
    */
    public string Description {get; set;}
    public string Title {get; set;}
    public string Price {get; set;}

    public int Id {get; }

    private static List<Order> _instances = new List<Order>{};
    
    public Order(string title,string price,string description)
    {
      Description = description;
      Price = price;
      Title = title;
      _instances.Add(this);
      Id = _instances.Count;
    }

    // Static Methods
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }


    //Instance methods




  }
  
 }

