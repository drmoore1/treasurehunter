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
      int damage = (random.Next(1, 5) * ThisGame.Player.PoisonRate);
      while (damage > 0)
      {

        // Console.Beep();
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.Black;
        ThisGame.Header(ThisGame);
        System.Threading.Thread.Sleep(150);
        Console.ResetColor();
        ThisGame.Player.Health--;
        damage--;
      }


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