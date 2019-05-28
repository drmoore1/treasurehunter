using System;
using System.Collections.Generic;

namespace treasurehunter.Models
{

  class Neural
  {
    public Neural(string input, int number)
    {
      String = input;
      CommandNumber = number;
    }

    public string String { get; set; }
    public int CommandNumber { get; set; }
    public bool Positive { get; set; } = false;
    public Neural Connect { get; set; }

    void Think(int choice, string input)
    {
      String Input = input;
      #region This is why you don't drink and code.... integer references to shortcut a two character command?!?!
      // oh wait... I wanted to use integers so I can easily instatiate a list of neurons that perform all functions with one command!!!!
      int Choice = choice;
      switch (Choice)
      {
        case 1:
          Go(Input);
          break;
        case 2:
          No(Input);
          break;
        case 3:
          Or(Input);
          break;
        case 4:
          Rt(Input);
          break;
        case 5:
          Th(Input);
          break;
        case 6:
          Ea(Input);
          break;
        case 7:
          As(Input);
          break;
        case 8:
          St(Input);
          break;
        case 9:
          So(Input);
          break;
        case 10:
          Ou(Input);
          break;
        case 11:
          Ut(Input);
          break;
        case 12:
          We(Input);
          break;
        case 13:
          Es(Input);
          break;
        case 14:
          He(Input);
          break;
        case 15:
          El(Input);
          break;
        case 16:
          Lp(Input);
          break;
        case 17:
          Lo(Input);
          break;
        case 18:
          Oo(Input);
          break;
        case 19:
          Ok(Input);
          break;
        case 20:
          In(Input);
          break;
        case 21:
          Nv(Input);
          break;
        case 22:
          Ve(Input);
          break;
        case 23:
          En(Input);
          break;
        case 24:
          Nt(Input);
          break;
        case 25:
          To(Input);
          break;
        case 26:
          Ry(Input);
          break;
        case 27:
          Ta(Input);
          break;
        case 28:
          Ak(Input);
          break;
        case 29:
          Ke(Input);
          break;
        case 30:
          Qu(Input);
          break;
        case 31:
          Ui(Input);
          break;
        case 32:
          It(Input);
          break;
        default:
          break;
      }
      #endregion
    }

    //1
    void Go(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("go"))
      {
        Positive = true;
      }
    }
    //2
    void No(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("no"))
      {
        Positive = true;
      }
    }
    //3
    void Or(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("or"))
      {
        Positive = true;
      }
    }
    //4
    void Rt(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("rt"))
      {
        Positive = true;
      }
    }
    //5
    void Th(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("th"))
      {
        Positive = true;
      }
    }
    //6
    void Ea(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("ea"))
      {
        Positive = true;
      }
    }
    //7
    void As(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("as"))
      {
        Positive = true;
      }
    }
    //8
    void St(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("st"))
      {
        Positive = true;
      }
    }
    //9
    void So(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("so"))
      {
        Positive = true;
      }
    }
    //10
    void Ou(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("ou"))
      {
        Positive = true;
      }
    }
    //11
    void Ut(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("ut"))
      {
        Positive = true;
      }
    }
    //12
    void We(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("we"))
      {
        Positive = true;
      }
    }
    //13
    void Es(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("es"))
      {
        Positive = true;
      }
    }
    //14
    void He(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("he"))
      {
        Positive = true;
      }
    }
    //15
    void El(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("el"))
      {
        Positive = true;
      }
    }
    //16
    void Lp(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("lp"))
      {
        Positive = true;
      }
    }
    //17
    void Lo(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("lo"))
      {
        Positive = true;
      }
    }
    //18
    void Oo(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("oo"))
      {
        Positive = true;
      }
    }
    //19
    void Ok(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("ok"))
      {
        Positive = true;
      }
    }
    //20
    void In(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("in"))
      {
        Positive = true;
      }
    }
    //21
    void Nv(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("nv"))
      {
        Positive = true;
      }
    }
    //22
    void Ve(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("ve"))
      {
        Positive = true;
      }
    }
    //23
    void En(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("en"))
      {
        Positive = true;
      }
    }
    //24
    void Nt(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("nt"))
      {
        Positive = true;
      }
    }
    //25
    void To(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("to"))
      {
        Positive = true;
      }
    }
    //26
    void Ry(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("ry"))
      {
        Positive = true;
      }
    }
    //27
    void Ta(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("ta"))
      {
        Positive = true;
      }
    }
    //28
    void Ak(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("ak"))
      {
        Positive = true;
      }
    }
    //29
    void Ke(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("ke"))
      {
        Positive = true;
      }
    }
    //30
    void Qu(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("qu"))
      {
        Positive = true;
      }
    }
    //31
    void Ui(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("ui"))
      {
        Positive = true;
      }
    }
    //32
    void It(string letters)
    {
      string Letters = letters;
      if (Letters.Contains("it"))
      {
        Positive = true;
      }
    }

  }
}
