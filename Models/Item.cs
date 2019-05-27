using System;
using System.Collections.Generic;
using System.Linq;
namespace treasurehunter.Models
{

  class Item
  {
    public Item RandItem()
    {
      Random r = new Random();
      if (r.Next(0, 10) < 5)
      {
        return null;
      }
      else
      {
        List<string> Options = new List<string> { "A piece of dog fur", "Antidote", "A clue", "Rubber Chicken", "Poison" };
        string name = Options.ElementAt(r.Next(0, Options.Count));
        Item Item = new Item(name);
        return Item;
      }
    }

    public Game TakeItem(Game game)
    {
      Game ThisGame = game;
      string userInput = Console.ReadLine().ToLower();
      return ThisGame;
    }
    public Item(string name)
    {
      Name = name;
    }
    public string Name { get; set; }
  }

}