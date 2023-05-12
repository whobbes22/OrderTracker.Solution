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
    
    public Vendor(string name, string script)
    {
      Description = script;
      Name = name;
    }
  }
  
 }

