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
      testPlant.Thirst += 4;
      Console.WriteLine("NEW THIRST: " + testPlant.Thirst);
    }
    else if (userDailyChoice.Contains("feed"))
    {
      testPlant.Hunger += 4;
      Console.WriteLine("NEW HUNGER: " + testPlant.Hunger);
    }
     else if (userDailyChoice.Contains("walk"))
    {
      testPlant.Sunshine += 4;
      Console.WriteLine("NEW SUNSHINE: " + testPlant.Sunshine);
    }
     else if (userDailyChoice.Contains("tv"))
    {
      // testPlant.Hunger += 4;
      Console.WriteLine("Youre a lazy douche");
    }
    }

  
   
  }
}