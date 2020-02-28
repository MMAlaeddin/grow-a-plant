using System;
using System.Collections.Generic;
using Models;

namespace GrowYourOwnPlant
{ 
  class Program
  {
    static void Main()
    {
    Console.WriteLine("Hello! You just received a new plant! What would you like to name it?");
    string nameResponse = Console.ReadLine().ToLower();
    Plant testPlant = new Plant (nameResponse, 5, 5, 5, 1, "alive");
    Console.WriteLine(testPlant.Name);
    Console.WriteLine(testPlant.Thirst);
    Console.WriteLine(testPlant.Hunger);
    Console.WriteLine(testPlant.Sunshine);



// Daily choice below
    
      Plant.DailyChoice(testPlant);


    }
  }
}
