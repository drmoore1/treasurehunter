using System;
using treasurehunter.Models;
namespace treasurehunter
{
  class Program
  {
    //  This program using a messy situation for room navigation
    //  it would have been MUCH easier to have the navigation done by coordinates
    //  I wanted to use multidimensional linked list to make it happen though.

    static void Main(string[] args)
    {

      Player Player = new Player("Hero");
      Room MyRoom = new Room(0, 0);
      MyRoom = MyRoom.FirstRoom();
      Game ThisGame = new Game(Player, MyRoom);
      Console.Clear();

      ThisGame.Greeting();
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

