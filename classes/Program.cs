﻿using System;

namespace MyApplication
{
  class Color
  {
    string mycolor = "black";

    static void Main(string[] args)
    {
      Color myObj = new Color();
      Console.WriteLine(myObj.mycolor);
    }
  }
}