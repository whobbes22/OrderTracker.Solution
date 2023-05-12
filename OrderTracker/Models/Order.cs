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
    public Order(string title,string price,string description)
    {
      Description = description;
      Price = price;
      Title = title;
    }

  }
  
 }

