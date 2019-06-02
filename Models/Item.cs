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
      if (r.Next(0, 10) < 7)
      {
        return null;
      }
      else
      {
        List<string> Options = new List<string> { "DogFur", "Antidote", "Clue", "Poison" };
        List<string> Descriptions = new List<string> { "A small clump of dogs fur.", "Take To Reduce Poison", "A mysterious emblem...", "A vial of poison." };
        int temp = r.Next(0, Options.Count);
        string name = Options.ElementAt(temp);
        string description = Descriptions.ElementAt(temp);
        Item Item = new Item(name, description);
        return Item;
      }
    }

    public Game TakeItem(Game game)
    {
      Game ThisGame = game;
      string userInput = Console.ReadLine().ToLower();
      return ThisGame;
    }
    public Item(string name, string description)
    {
      Name = name;
      Description = description;
    }
    public string Name { get; set; }
    public string Description { get; set; }
  }

}