using System;
using System.Collections.Generic;
namespace treasurehunter.Models
{

  class Player
  {
    public Game Poison(Game game)
    {
      Game ThisGame = game;
      Random random = new Random();
      ThisGame.Player.Health = ThisGame.Player.Health - (random.Next(1, 8) * ThisGame.Player.PoisonRate);

      return ThisGame;
    }
    public Player(string name)
    {
      Name = name;
      Inventory = new List<Item> { };
      PoisonRate = 1;
    }
    public string Name { get; set; }
    public int Health { get; set; } = 100;
    public List<Item> Inventory { get; set; }
    public int PoisonRate { get; set; }
  }
}