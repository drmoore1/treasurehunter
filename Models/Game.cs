using System;
using System.Collections.Generic;

namespace treasurehunter.Models
{

  class Game
  {

    public Game(Player player, Room room)
    {
      Player = player;
      CurrentRoom = room;
      AllRooms.Add(CurrentRoom);
    }
    public List<Room> AllRooms { get; set; } = new List<Room> { };
    public Player Player { get; set; }
    public Room CurrentRoom { get; set; }
    public string Direction { get; set; }


    // public string GetDirection()
    // {
    //   System.Console.WriteLine("Which direction will you go?");
    //   string answer = Console.ReadLine().ToLower();
    //   return answer;
    // }
    public void Greeting()
    {
      Console.Clear();
      SplashScreen();
      Console.ReadKey(true);
      Console.Clear();
      System.Console.WriteLine("You awake... cold and sore.");
      System.Console.WriteLine("......  remember.. what happened...");
      Console.ReadKey(true);
      Console.Clear();
      System.Console.WriteLine("There was a party..");
      System.Console.WriteLine();
      System.Console.WriteLine("          there was.. an attack..");
      System.Console.WriteLine();
      System.Console.WriteLine("I've been..  I've been...");
      Console.ReadKey(true);
      Console.Clear();
      System.Console.WriteLine("poisoned...");
      System.Console.WriteLine();
      System.Console.WriteLine("I must find the antidote...  soon.");


    }
    public Game TakeTurn(Game game)
    {
      Game ThisGame = game;

      Console.Clear();
      System.Console.WriteLine("Commands: Go North, Go East, Go South, Go West, Look, Take, Inventory, Quit");
      System.Console.WriteLine($"Current Location: {ThisGame.CurrentRoom.Latitude} by {ThisGame.CurrentRoom.Longitude}");
      System.Console.WriteLine($"Current Health  : {ThisGame.Player.Health}");
      System.Console.WriteLine();
      System.Console.WriteLine($"{ThisGame.CurrentRoom.Description}");
      System.Console.WriteLine();
      ThisGame = ThisGame.GetDirection(ThisGame);

      return ThisGame;
    }
    public void Death()
    {
      Console.Clear();
      #region ANSII Art
      string line1 = "    .o oOOOOOOOo                                            OOOo";
      string line2 = "    Ob.OOOOOOOo  OOOo.      oOOo.                      .adOOOOOOO";
      string line3 = "    OboO''''''''''''.OOo. .oOOOOOo.    OOOo.oOOOOOo..'''''''''OO";
      string line4 = "    OOP.oOOOOOOOOOOO 'POOOOOOOOOOOo.   `'OOOOOOOOOP,OOOOOOOOOOOB'";
      string line5 = "    `O'OOOO'     `OOOOo'OOOOOOOOOOO` .adOOOOOOOOO'oOOO'    `OOOOo";
      string line6 = "    .OOOO'            `OOOOOOOOOOOOOOOOOOOOOOOOOO'            `OO";
      string line7 = "    OOOOO                 ''OOOOOOOOOOOOOOOO'`                oOO";
      string line8 = "   oOOOOOba.                .adOOOOOOOOOOba               .adOOOOo.";
      string line9 = "  oOOOOOOOOOOOOOba.    .adOOOOOOOOOO@^OOOOOOOba.     .adOOOOOOOOOOOO";
      string line10 = " OOOOOOOOOOOOOOOOO.OOOOOOOOOOOOOO'`  ''OOOOOOOOOOOOO.OOOOOOOOOOOOOO";
      string line11 = " 'OOOO'       'YOoOOOOMOIONODOO'`  .   ''OOROAOPOEOOOoOY'     'OOO'";
      string line12 = "    Y           'OOOOOOOOOOOOOO: .oOOo. :OOOOOOOOOOO?'         :`";
      string line13 = "    :            .oO%OOOOOOOOOOo.OOOOOO.oOOOOOOOOOOOO?         .";
      string line14 = "    .            oOOP' % OOOOOOOOoOOOOOOO ? oOOOOO ? OOOO'OOo";
      string line15 = "                 '%o  OOOO' % OOOO % '%OOOOO'OOOOOO'OOO':";
      string line16 = "                      `$'  `OOOO' `O'Y ' `OOOO'  o             .";
      string line17 = "    .                  .     OP'          : o.";
      string line18 = "                              :";
      #endregion
      System.Console.WriteLine(line1);
      System.Console.WriteLine(line2);
      System.Console.WriteLine(line3);
      System.Console.WriteLine(line4);
      System.Console.WriteLine(line5);
      System.Console.WriteLine(line6);
      System.Console.WriteLine(line7);
      System.Console.WriteLine(line8);
      System.Console.WriteLine(line9);
      System.Console.WriteLine(line10);
      System.Console.WriteLine(line11);
      System.Console.WriteLine(line12);
      System.Console.WriteLine(line13);
      System.Console.WriteLine(line14);
      System.Console.WriteLine(line15);
      System.Console.WriteLine(line16);
      System.Console.WriteLine(line17);
      System.Console.WriteLine(line18);
      System.Console.WriteLine();
      System.Console.WriteLine();
      System.Console.WriteLine(".... you have succumbed to the poison....");
    }
    public void Win()
    {
      Console.Clear();
      System.Console.WriteLine();
      System.Console.WriteLine("You have recovered from the poison...");
      Console.ReadKey(true);
      System.Console.WriteLine();
      System.Console.WriteLine();
      System.Console.WriteLine("there are so many questions to answer still...");
      System.Console.WriteLine();
      System.Console.WriteLine();
      System.Console.WriteLine("                                  Stay tuned for chapter 2");
      Environment.Exit(0);
    }
    public void SplashScreen()
    {
      System.Console.WriteLine(" ######  ####### ###  #####  ####### #     # ####### ######  ");
      System.Console.WriteLine(" #     # #     #  #  #     # #     # ##    # #       #     # ");
      System.Console.WriteLine(" #     # #     #  #  #       #     # # #   # #       #     # ");
      System.Console.WriteLine(" ######  #     #  #   #####  #     # #  #  # #####   #     # ");
      System.Console.WriteLine(" #       #     #  #        # #     # #   # # #       #     # ");
      System.Console.WriteLine(" #       #     #  #  #     # #     # #    ## #       #     # ");
      System.Console.WriteLine(" #       ####### ###  #####  ####### #     # ####### ######  ");
      System.Console.WriteLine();
      System.Console.WriteLine();
      System.Console.WriteLine("Press Any Key To Continue");
      Console.ReadKey(true);
    }
    public Game GetDirection(Game game)
    {
      Game ThisGame = game;
      string userInput = "";
      userInput = Console.ReadLine();
      userInput = userInput.ToLower();
      string[] UserInput = userInput.Split();

      foreach (string word in UserInput)
      {
        if (word == "go")
        {
          foreach (string word2 in UserInput)
          {
            if (word2 == "north")
            {
              ThisGame.Direction = "north";
              ThisGame = ThisGame.CurrentRoom.Navigator(ThisGame);
              break;
            }
            if (word2 == "east")
            {
              ThisGame.Direction = "east";
              ThisGame = ThisGame.CurrentRoom.Navigator(ThisGame);
              break;
            }
            if (word2 == "south")
            {
              ThisGame.Direction = "south";
              ThisGame = ThisGame.CurrentRoom.Navigator(ThisGame);
              break;
            }
            if (word2 == "west")
            {
              ThisGame.Direction = "west";
              ThisGame = ThisGame.CurrentRoom.Navigator(ThisGame);
              break;
            }
          }

        }
        if (word == "look")
        {
          CurrentRoom.Look(ThisGame);
          break;
        }
        if (word == "take")
        {
          foreach (string word2 in UserInput)
          {
            foreach (Item item in ThisGame.CurrentRoom.Inventory)
            {
              if (item.Name.ToLower() == "poison")
              {
                ThisGame.CurrentRoom.Inventory.Remove(item);
                ThisGame.Player.PoisonRate++;
                return ThisGame;
              }
              if (item.Name.ToLower() == "antidote")
              {
                ThisGame.CurrentRoom.Inventory.Remove(item);
                ThisGame.Player.PoisonRate--;
                return ThisGame;
              }
              if (item.Name.ToLower() != "poison" && item.Name.ToLower() != "antidote")
              {
                ThisGame.Player.Inventory.Add(item);
                ThisGame.CurrentRoom.Inventory.Remove(item);
                return ThisGame;
              }


            }
          }



        }
        if (word == "inventory")
        {
          Console.Clear();
          System.Console.WriteLine("Your Current Inventory Includes:");
          foreach (Item item in ThisGame.Player.Inventory)
          {
            System.Console.WriteLine(item.Name);
            System.Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey(true);

          }
          return ThisGame;
        }

        if (word == "quit")
        {
          Player.Health = 0;
          Death();
          Environment.Exit(0);
          break;
        }
        return ThisGame;
      }
      #region OLD CODE
      // if (userInput == "quit" || userInput == "q")
      // {
      //   Player.Health = 0;
      //   Death();
      //   Environment.Exit(0);
      // }
      // if (userInput == "north" || userInput == "n" || userInput == "go north")
      // {
      //   ThisGame.Direction = "north";
      //   ThisGame = ThisGame.CurrentRoom.Navigator(ThisGame);

      // }
      // if (userInput == "east" || userInput == "e" || userInput == "go east")
      // {
      //   ThisGame.Direction = "east";
      //   ThisGame = ThisGame.CurrentRoom.Navigator(ThisGame);
      // }
      // if (userInput == "south" || userInput == "s" || userInput == "go south")
      // {
      //   ThisGame.Direction = "south";
      //   ThisGame = ThisGame.CurrentRoom.Navigator(ThisGame);
      // }
      // if (userInput == "west" || userInput == "w" || userInput == "go west")
      // {
      //   ThisGame.Direction = "west";
      //   ThisGame = ThisGame.CurrentRoom.Navigator(ThisGame);
      // }
      // if (userInput == "look" || userInput == "l")
      // {
      //   ThisGame = CurrentRoom.Look(ThisGame);
      // }
      // if (true)
      // {

      // }
      #endregion
      return ThisGame;
    }
  }
}