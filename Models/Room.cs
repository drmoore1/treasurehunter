using System;
using System.Linq;
using System.Collections.Generic;


namespace treasurehunter.Models
{

  class Room
  {
    public Room(int lat, int lon)
    {
      Latitude = lat;
      Longitude = lon;
    }
    public Game RoomMaker(Game game)
    {
      Game ThisGame = game;
      Item tempItem = new Item("temp");
      Room RoomNorth = null;
      Room RoomEast = null;
      Room RoomSouth = null;
      Room RoomWest = null;
      int Lat = ThisGame.CurrentRoom.Latitude;
      int Lon = ThisGame.CurrentRoom.Longitude;
      #region Adjusts Lat/Lon to location of new room.
      if (ThisGame.Direction == "north")
      {
        Lat = ThisGame.CurrentRoom.Latitude + 1;
        Lon = ThisGame.CurrentRoom.Longitude;
      }
      if (ThisGame.Direction == "east")
      {
        Lat = ThisGame.CurrentRoom.Latitude;
        Lon = ThisGame.CurrentRoom.Longitude + 1;
      }
      if (ThisGame.Direction == "south")
      {
        Lat = ThisGame.CurrentRoom.Latitude - 1;
        Lon = ThisGame.CurrentRoom.Longitude;
      }
      if (ThisGame.Direction == "west")
      {
        Lat = ThisGame.CurrentRoom.Latitude;
        Lon = ThisGame.CurrentRoom.Longitude - 1;
      }
      #endregion
      // Sets neighboring rooms from list of existing rooms.... May need error handling...

      foreach (Room neighbor in ThisGame.AllRooms)
      {
        if (neighbor.Latitude + 1 == Lat && neighbor.Longitude == Lon)
        {
          RoomSouth = neighbor;
        }
        if (neighbor.Latitude == Lat && neighbor.Longitude + 1 == Lon)
        {
          RoomWest = neighbor;
        }
        if (neighbor.Latitude - 1 == Lat && neighbor.Longitude == Lon)
        {
          RoomNorth = neighbor;
        }
        if (neighbor.Latitude == Lat && neighbor.Longitude - 1 == Lon)
        {
          RoomEast = neighbor;
        }
      }

      Room Room = new Room(Lat, Lon);
      Room.Description = RoomDescription();
      tempItem = tempItem.RandItem();
      if (tempItem != null) { Room.Inventory.Add(tempItem); }


      Room.NorthConnection = RoomNorth;
      Room.EastConnection = RoomEast;
      Room.SouthConnection = RoomSouth;
      Room.WestConnection = RoomWest;
      #region Code to store THIS room as connections from existing rooms
      if (RoomNorth != null)
      {
        RoomNorth.SouthConnection = Room;
      }
      if (RoomEast != null)
      {
        RoomEast.WestConnection = Room;
      }
      if (RoomSouth != null)
      {
        RoomSouth.NorthConnection = Room;
      }
      if (RoomWest != null)
      {
        RoomWest.EastConnection = Room;
      }
      #endregion
      ThisGame.AllRooms.Add(Room);
      ThisGame.CurrentRoom = Room;

      return ThisGame;
    }

    public Game Navigator(Game game)
    {
      Game ThisGame = game;
      switch (ThisGame.Direction)
      {
        case "north":
          if (ThisGame.CurrentRoom.NorthConnection != null)
          {
            ThisGame.CurrentRoom = ThisGame.CurrentRoom.NorthConnection;
            ThisGame.Player.Poison(ThisGame);

            return ThisGame;
          }
          else
          {
            ThisGame = RoomMaker(ThisGame);
            ThisGame.Player.Poison(ThisGame);
            return ThisGame;
          }

        case "east":
          if (ThisGame.CurrentRoom.EastConnection != null)
          {
            ThisGame.CurrentRoom = ThisGame.CurrentRoom.EastConnection;
            ThisGame.Player.Poison(ThisGame);
            return ThisGame;
          }
          else
          {
            ThisGame = RoomMaker(ThisGame);
            ThisGame.Player.Poison(ThisGame);
            return ThisGame;
          }

        case "south":
          if (ThisGame.CurrentRoom.SouthConnection != null)
          {
            ThisGame.CurrentRoom = ThisGame.CurrentRoom.SouthConnection;
            ThisGame.Player.Poison(ThisGame);
            return ThisGame;

          }
          else { ThisGame = RoomMaker(ThisGame); }
          ThisGame.Player.Poison(ThisGame);
          return ThisGame;
        case "west":
          if (ThisGame.CurrentRoom.WestConnection != null)
          {
            ThisGame.CurrentRoom = ThisGame.CurrentRoom.WestConnection;
            ThisGame.Player.Poison(ThisGame);
            return ThisGame;
          }
          else
          {
            ThisGame = RoomMaker(ThisGame);
          }
          ThisGame.Player.Poison(ThisGame);
          return ThisGame;
        default:
          return ThisGame;

      }

    }
    private string RoomDescription()
    {
      List<string> options = new List<string> { "This room has been ransacked by someone recently. ", "This room seems neat and tidy, except a rug thats been shoved up against a wall in a heap. ", "This room was one of your favorite rooms before. ", "This room has been completely destroyed. " };
      List<string> options2 = new List<string> { "You feel a chilly breeze.", "Bloody foot prints mark a scuffle on the floor.", "You wonder where your dog is...", "There is a single drop of blood on a wall.", "", "" };
      Random rnd = new Random();
      Random rnd2 = new Random();

      string desc1 = options.ElementAt(rnd.Next(0, options.Count));
      string desc2 = options2.ElementAt(rnd2.Next(0, options2.Count));
      string description = "" + desc1 + "" + desc2;

      return description;



    }
    public Room FirstRoom()
    {
      Room myRoom = new Room(0, 0);
      myRoom.Description = "Your own blood has pooled on the floor from a cut on your arm.";
      return myRoom;
    }

    public void Look(Game game)
    {
      Game ThisGame = game;
      Console.Clear();
      System.Console.WriteLine("Commands: Go North, Go East, Go South, Go West, Look, Take (ITEM), Quit");
      System.Console.WriteLine("------------------------------------------------------------------------");
      System.Console.WriteLine($"Current Location: {ThisGame.CurrentRoom.Latitude} by {ThisGame.CurrentRoom.Longitude}");
      System.Console.WriteLine("------------------------------------------------------------------------");
      System.Console.WriteLine($"Current Health  : {ThisGame.Player.Health}");
      System.Console.WriteLine();
      System.Console.WriteLine("The Rooms Description: ");
      System.Console.WriteLine();
      System.Console.WriteLine(ThisGame.CurrentRoom.Description);
      if (ThisGame.CurrentRoom.Inventory.Count == 0)
      {
        System.Console.WriteLine();
        System.Console.WriteLine("There are no items in this room");
      }
      else
      {
        System.Console.WriteLine();
        System.Console.WriteLine("The following items are in the room:");
        foreach (Item item in ThisGame.CurrentRoom.Inventory)
        {
          System.Console.WriteLine(item.Name);
        }

      }
      // Console.ReadKey(true);
      ThisGame.GetDirection(ThisGame);

    }


    #region Doors
    // attached doors... Not implemented.
    public Door NorthDoor { get; set; } = null;
    public Door EastDoor { get; set; } = null;
    public Door SouthDoor { get; set; } = null;
    public Door WestDoor { get; set; } = null;
    #endregion
    #region Attached Rooms
    //links for attached rooms
    public Room NorthConnection { get; set; } = null;
    public Room EastConnection { get; set; } = null;
    public Room SouthConnection { get; set; } = null;
    public Room WestConnection { get; set; } = null;
    #endregion
    //Description and room inventory
    public string Description { get; set; }
    public List<Item> Inventory { get; set; } = new List<Item> { };
    public int Latitude { get; set; }
    public int Longitude { get; set; }


  }
}