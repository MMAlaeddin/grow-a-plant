using System;
namespace Models
{
  public class Plant
  {
    public string Name { get; set; }
    public int Thirst { get; set;}
    public int Hunger { get; set; }
    public int Sunshine { get; set; }

    public Plant(string name, int thirst, int hunger, int sunshine)
    {
      Name = name;
      Thirst = thirst;
      Hunger = hunger;
      Sunshine = sunshine;
    }

    // Plant testPlant = new Plant (nameResponse, 5, 5, 5);
    // public static void NamePlant()
    // {
    // string nameResponse = Console.ReadLine().ToLower();
    // Console.WriteLine(testPlant.Name);
    // Console.WriteLine(testPlant.Thirst);
    // Console.WriteLine(testPlant.Hunger);
    // Console.WriteLine(testPlant.Sunshine);
    // }

    public static void DailyChoice(Plant testPlant)
    {
    Console.WriteLine("What would you like to do today?");
    string userDailyChoice = Console.ReadLine().ToLower();
    if (userDailyChoice.Contains("water"))
    {
      // testPlant.Thirst += 4;
      // Console.WriteLine("NEW THIRST: " + testPlant.Thirst);
      testPlant.GiveWater();

    }
    else if (userDailyChoice.Contains("walk"))
    {
      testPlant.GiveSun();
      // testPlant.Hunger += 4;
      // Console.WriteLine("NEW HUNGER: " + testPlant.Hunger);
    }
     else if (userDailyChoice.Contains("feed"))
    {
      testPlant.GiveFood();
      // testPlant.Sunshine += 4;
      // Console.WriteLine("NEW SUNSHINE: " + testPlant.Sunshine);
    }
     else if (userDailyChoice.Contains("tv"))
    {
      testPlant.DoNothing();
      // testPlant.Hunger += 4;
      Console.WriteLine("Youre a lazy douche");
    }
    }
    private void GiveWater()
    {
      Thirst += 4;
      Console.WriteLine("NEW THIRST: " + Thirst);
    }

    private void GiveFood()
    {
      Hunger += 4;
      Console.WriteLine("NEW Hunger: " + Thirst);
    }

    private void GiveSun()
    {
      Sunshine += 4;
      Console.WriteLine("NEW Sunshine: " + Sunshine);
    }

    private void DoNothing()
    {
      Thirst -= 1;
      Sunshine -= 1;
      Hunger -= 1;
      Console.WriteLine("NEW Sunshine: " + Sunshine);
    }

  
   
  }
}