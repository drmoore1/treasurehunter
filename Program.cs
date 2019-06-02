using System;
using treasurehunter.Models;

namespace treasurehunter
{
  class Program
  {

    static void Main(string[] args)
    {

      Player Player = new Player("Hero");
      Room MyRoom = new Room(0, 0);
      MyRoom = MyRoom.FirstRoom();
      Game ThisGame = new Game(Player, MyRoom);
      Console.Clear();
      // ThisGame.Scroll();
      // ThisGame.Greeting();
      while (ThisGame.Player.Health > 0)
      {
        if (ThisGame.Player.PoisonRate == 0)
        {
          ThisGame.Win();
        }
        ThisGame = ThisGame.TakeTurn(ThisGame);
      }
      ThisGame.Death();
    }
  }
}

