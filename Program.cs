using System;
using treasurehunter.Models;
namespace treasurehunter
{
  class Program
  {
    //  This program using a messy situation for room navigation
    //  it would have been MUCH easier to have the navigation done by coordinates
    //  I wanted to use multidimensional linked list to make it happen though.
    //  I THINK that it would be easier code for a computer to run, IF I had
    //     Not decided to then poll the list of rooms to find neighbors for a new room.
    //     For it to run faster it would have been better to simply navigate the links
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

