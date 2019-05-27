using System;
using System.Collections.Generic;
using System.Threading;

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

    public void Greeting()
    {
      Console.Clear();
      System.Console.WriteLine(); System.Console.WriteLine(); System.Console.WriteLine(); System.Console.WriteLine();
      System.Console.WriteLine("              You awake... cold and sore.");
      System.Console.WriteLine();
      System.Threading.Thread.Sleep(1650);
      System.Console.WriteLine("                     ......  remember.. what happened...");
      System.Threading.Thread.Sleep(2000);
      System.Console.WriteLine(); System.Console.WriteLine(); System.Console.WriteLine();
      System.Console.WriteLine("                   Press Any Key to Continue");
      Console.ReadKey(true);
      Console.Clear();
      System.Console.WriteLine(); System.Console.WriteLine(); System.Console.WriteLine(); System.Console.WriteLine();
      System.Console.WriteLine("                                There was a party..");
      System.Console.WriteLine(); System.Console.WriteLine(); System.Console.WriteLine();
      System.Threading.Thread.Sleep(1900);
      System.Console.WriteLine("            there was.. an attack..");
      System.Console.WriteLine(); System.Console.WriteLine();
      System.Threading.Thread.Sleep(1850);
      System.Console.WriteLine("                          I've been..  I've been...");
      System.Threading.Thread.Sleep(2000); System.Console.WriteLine(); System.Console.WriteLine(); System.Console.WriteLine();
      System.Console.WriteLine("                    Press Any Key to Continue");
      Console.ReadKey(true);
      Console.Clear();
      System.Threading.Thread.Sleep(1800); System.Console.WriteLine(); System.Console.WriteLine(); System.Console.WriteLine();
      System.Console.WriteLine("                              poisoned...");
      System.Console.WriteLine(); System.Console.WriteLine(); System.Console.WriteLine();
      System.Threading.Thread.Sleep(1950);
      System.Console.WriteLine("                   I must find the antidote...  soon.");
      System.Threading.Thread.Sleep(1750);
      System.Console.WriteLine(); System.Console.WriteLine(); System.Console.WriteLine();
      System.Console.WriteLine("                        Press Any Key to Continue");
      Console.ReadKey(true);


    }
    public Game TakeTurn(Game game)
    {
      Game ThisGame = game;

      ThisGame = ThisGame.Header(ThisGame);
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
      Console.ForegroundColor = ConsoleColor.DarkRed;
      int position = 20;
      Console.CursorVisible = false;
      Console.SetCursorPosition(0, 20);
      if (position == 20)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
        System.Console.WriteLine(line1);
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 19)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
        System.Console.WriteLine(line1);
        System.Console.WriteLine(line2);
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 18)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
        System.Console.WriteLine(line1);
        System.Console.WriteLine(line2);
        System.Console.WriteLine(line3);
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 17)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
        System.Console.WriteLine(line1);
        System.Console.WriteLine(line2);
        System.Console.WriteLine(line3);
        System.Console.WriteLine(line4);
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 16)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
        System.Console.WriteLine(line1);
        System.Console.WriteLine(line2);
        System.Console.WriteLine(line3);
        System.Console.WriteLine(line4);
        System.Console.WriteLine(line5);
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 15)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
        System.Console.WriteLine(line1);
        System.Console.WriteLine(line2);
        System.Console.WriteLine(line3);
        System.Console.WriteLine(line4);
        System.Console.WriteLine(line5);
        System.Console.WriteLine(line6);
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 14)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
        System.Console.WriteLine(line1);
        System.Console.WriteLine(line2);
        System.Console.WriteLine(line3);
        System.Console.WriteLine(line4);
        System.Console.WriteLine(line5);
        System.Console.WriteLine(line6);
        System.Console.WriteLine(line7);
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 13)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
        System.Console.WriteLine(line1);
        System.Console.WriteLine(line2);
        System.Console.WriteLine(line3);
        System.Console.WriteLine(line4);
        System.Console.WriteLine(line5);
        System.Console.WriteLine(line6);
        System.Console.WriteLine(line7);
        System.Console.WriteLine(line8);
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 12)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
        System.Console.WriteLine(line1);
        System.Console.WriteLine(line2);
        System.Console.WriteLine(line3);
        System.Console.WriteLine(line4);
        System.Console.WriteLine(line5);
        System.Console.WriteLine(line6);
        System.Console.WriteLine(line7);
        System.Console.WriteLine(line8);
        System.Console.WriteLine(line9);
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 11)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
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
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 10)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
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
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 9)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
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
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 8)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
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
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 7)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
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
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 6)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
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
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 5)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
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
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 4)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
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
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 3)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
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
        position--;
        System.Threading.Thread.Sleep(60);
      }

      while (position < 3 && position > 0)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
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
        position--;
        System.Threading.Thread.Sleep(60);
      }

      System.Threading.Thread.Sleep(2500);
      System.Console.WriteLine();
      System.Console.WriteLine();
      System.Console.WriteLine("                   .... you have succumbed to the poison....");
      Console.CursorVisible = true;
      Console.ResetColor();
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
      Console.ResetColor();
      Environment.Exit(0);
    }


    public Game GetDirection(Game game)
    {
      Game ThisGame = game;
      string userInput = "";
      Console.SetCursorPosition(19, 16);
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
          ThisGame.Player.Inventory = Inventory(ThisGame.Player.Inventory);
          return ThisGame;
        }

        if (word == "quit")
        {
          Player.Health = 0;
          Death();
          Environment.Exit(0);
          break;
        }
        if (word == "help")
        {
          Help();
        }
        return ThisGame;
      }

      return ThisGame;
    }
    void Help()
    {
      Console.Clear();
      System.Console.WriteLine("Available Commands");
      System.Console.WriteLine("Go North/East/South/West -");
      System.Console.WriteLine("Moves you to the next space in that direction");
      System.Console.WriteLine("Look - Searches the Room for items");
      System.Console.WriteLine("Take - Takes item from room");
      System.Console.WriteLine("Inventory - Displays Player Inventory");
      System.Console.WriteLine("Quit - ends game, you lose");
      System.Console.WriteLine();
      System.Console.WriteLine("Press Any Key to Continue");
      Console.ReadKey(true);
    }
    public Game Header(Game game)
    {
      Game ThisGame = game;
      Console.Clear();
      System.Console.WriteLine("Commands: Go North, Go East, Go South, Go West, Look, Take, Inventory, Help, Quit");
      Console.ForegroundColor = ConsoleColor.Gray;
      System.Console.WriteLine("---------------------------------------------------------------------------------");
      Console.ResetColor();
      System.Console.WriteLine($"Current Location: {ThisGame.CurrentRoom.Latitude} by {ThisGame.CurrentRoom.Longitude}");
      Console.ForegroundColor = ConsoleColor.Gray;
      System.Console.WriteLine("---------------------------------------------------------------------------------");
      Console.ResetColor();
      System.Console.WriteLine($"Current Health  : {ThisGame.Player.Health}");
      System.Console.WriteLine();
      System.Console.WriteLine($"{ThisGame.CurrentRoom.Description}");
      Console.SetCursorPosition(0, 16);
      System.Console.WriteLine("What will you do? ");
      Console.SetCursorPosition(0, 10);
      return ThisGame;
    }
    List<Item> Inventory(List<Item> inventory)
    {
      List<Item> playerInventory = inventory;
      Console.Clear();
      System.Console.WriteLine("Your Current Inventory Includes:");
      foreach (Item item in playerInventory)
      {
        System.Console.WriteLine(item.Name);
      }
      System.Console.WriteLine("Press Any Key To Continue");
      Console.ReadKey(true);
      return playerInventory;
    }
    public void Scroll()
    {
      Console.CursorVisible = false;
      int position = 20;
      #region ansii
      string line1 = " ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄        ▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄  ";
      string line2 = "▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░▌      ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░▌ ";
      string line3 = "▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌ ▀▀▀▀█░█▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌▐░▌░▌     ▐░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌";
      string line4 = "▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌     ▐░▌          ▐░▌       ▐░▌▐░▌▐░▌    ▐░▌▐░▌          ▐░▌       ▐░▌";
      string line5 = "▐░█▄▄▄▄▄▄▄█░▌▐░▌       ▐░▌     ▐░▌     ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌       ▐░▌▐░▌ ▐░▌   ▐░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░▌       ▐░▌";
      string line6 = "▐░░░░░░░░░░░▌▐░▌       ▐░▌     ▐░▌     ▐░░░░░░░░░░░▌▐░▌       ▐░▌▐░▌  ▐░▌  ▐░▌▐░░░░░░░░░░░▌▐░▌       ▐░▌";
      string line7 = "▐░█▀▀▀▀▀▀▀▀▀ ▐░▌       ▐░▌     ▐░▌      ▀▀▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌▐░▌   ▐░▌ ▐░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░▌       ▐░▌";
      string line8 = "▐░▌          ▐░▌       ▐░▌     ▐░▌               ▐░▌▐░▌       ▐░▌▐░▌    ▐░▌▐░▌▐░▌          ▐░▌       ▐░▌";
      string line9 = "▐░▌          ▐░█▄▄▄▄▄▄▄█░▌ ▄▄▄▄█░█▄▄▄▄  ▄▄▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌▐░▌     ▐░▐░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄█░▌";
      string line10 = "▐░▌          ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌      ▐░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░▌ ";
      string line11 = " ▀            ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀        ▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀  ";
      #endregion
      Console.SetCursorPosition(0, 20);
      if (position == 20)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
        System.Console.WriteLine(line1);
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 19)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
        System.Console.WriteLine(line1);
        System.Console.WriteLine(line2);
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 18)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
        System.Console.WriteLine(line1);
        System.Console.WriteLine(line2);
        System.Console.WriteLine(line3);
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 17)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
        System.Console.WriteLine(line1);
        System.Console.WriteLine(line2);
        System.Console.WriteLine(line3);
        System.Console.WriteLine(line4);
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 16)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
        System.Console.WriteLine(line1);
        System.Console.WriteLine(line2);
        System.Console.WriteLine(line3);
        System.Console.WriteLine(line4);
        System.Console.WriteLine(line5);
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 15)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
        System.Console.WriteLine(line1);
        System.Console.WriteLine(line2);
        System.Console.WriteLine(line3);
        System.Console.WriteLine(line4);
        System.Console.WriteLine(line5);
        System.Console.WriteLine(line6);
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 14)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
        System.Console.WriteLine(line1);
        System.Console.WriteLine(line2);
        System.Console.WriteLine(line3);
        System.Console.WriteLine(line4);
        System.Console.WriteLine(line5);
        System.Console.WriteLine(line6);
        System.Console.WriteLine(line7);
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 13)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
        System.Console.WriteLine(line1);
        System.Console.WriteLine(line2);
        System.Console.WriteLine(line3);
        System.Console.WriteLine(line4);
        System.Console.WriteLine(line5);
        System.Console.WriteLine(line6);
        System.Console.WriteLine(line7);
        System.Console.WriteLine(line8);
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 12)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
        System.Console.WriteLine(line1);
        System.Console.WriteLine(line2);
        System.Console.WriteLine(line3);
        System.Console.WriteLine(line4);
        System.Console.WriteLine(line5);
        System.Console.WriteLine(line6);
        System.Console.WriteLine(line7);
        System.Console.WriteLine(line8);
        System.Console.WriteLine(line9);
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 11)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
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
        position--;
        System.Threading.Thread.Sleep(60);
      }
      if (position == 10)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
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
        position--;
        System.Threading.Thread.Sleep(60);
      }
      while (position < 10 && position > 1)
      {
        Console.Clear();
        Console.SetCursorPosition(0, position);
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
        position--;
        System.Threading.Thread.Sleep(60);
      }
      Console.SetCursorPosition(30, 20);
      System.Console.WriteLine("Press Any Key To Continue");
      Console.CursorVisible = true;
      Console.ReadKey(true);
    }

  }
}