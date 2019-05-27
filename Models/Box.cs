using System;
using System.Collections.Generic;

namespace treasurehunter.Models
{

  class Box
  {
    public Box()
    {
      Locked = false;
      Inventory = new List<Item> { };
      Key = "";
      Description = "";
    }
    public List<Item> Inventory { get; set; }
    public bool Locked { get; set; }
    public string Key { get; set; }
    public string Description { get; set; }
  }
}