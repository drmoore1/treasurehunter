using System;
using System.Collections.Generic;

namespace treasurehunter.Models
{

  class Network
  {
    public Network(int layer)
    {
      int LayerId = layer;

    }
    public List<Neural> Layer { get; set; } = new List<Neural> { };
    public int LayerId { get; set; }


  }
}