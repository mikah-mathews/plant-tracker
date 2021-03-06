using System;
using System.Collections.Generic;


namespace PlantCare
{
  public class Program
  {
    public static void Main()
    {
   
      List<PlantMakeup> Plant = new List<PlantMakeup>();

      Console.WriteLine("What type of plant do you want to take care of?");
      Console.WriteLine("Venus-Flytrap, Succulent, or Sunflower");
      string plantType = Console.ReadLine();

      Console.WriteLine("What do you want to name your plant?");
      string plantName = Console.ReadLine();

      Plant.Add(new PlantMakeup(plantType, plantName, "seed"));

      Console.WriteLine("Your plant's type is: " + plantType);
      Console.WriteLine("Your plant's name is: " + plantName);
      Console.WriteLine(plantName + " is currently a seed.");
      Console.WriteLine("What action do you want to do?");
      Console.WriteLine("water || feed || sunshine || weed || read || quit");
      string action = Console.ReadLine();

      while (action != "quit" || action != "Quit")
      {
        Console.WriteLine("ACTION 1****************");
        Console.WriteLine(action);
        Console.WriteLine("----------------");
    
        if (action == "water" || action == "Water")
        {
          Console.WriteLine(PlantMakeup.WaterPlant());
          Console.WriteLine("----------------");
        }
        else if (action == "feed" || action == "Feed")
        {
          Console.WriteLine(PlantMakeup.FeedPlant());
          Console.WriteLine("----------------");
        }
        else if (action == "sunshine" || action == "Sunshine")
        {
          Console.WriteLine(PlantMakeup.SunPlant());
          Console.WriteLine("----------------");
        }
        else if (action == "weed" || action == "Weed")
        {
          Console.WriteLine(PlantMakeup.WeedPlant());
          Console.WriteLine("----------------");
        }
        else if (action == "read" || action == "Read")
        {
          Console.WriteLine(PlantMakeup.ReadPlant());
          Console.WriteLine("----------------");
        }
         else if (action == "quit" || action == "Quit")
        {
          Console.WriteLine("Goodbye.");
          break;
        }
        else
        {
          Console.WriteLine("I did not understand, please type one of the actions.");
          Console.WriteLine("----------------");
        }

        if (PlantMakeup.CareStats["water"] == 1 && PlantMakeup.CareStats["sun"] == 1)
        {
          Console.WriteLine(plantName + " is now a seedling!");
        }
        else if (PlantMakeup.CareStats["water"] == 2 && PlantMakeup.CareStats["sun"] == 2 && PlantMakeup.CareStats["weed"] == 1)
        {
          Console.WriteLine(plantName + " is now a teen plant! You found them listening to MCR!");
        }
        else if (PlantMakeup.CareStats["water"] == 3 && PlantMakeup.CareStats["sun"] == 3 && PlantMakeup.CareStats["weed"] == 2 && PlantMakeup.CareStats["feed"] == 1)
        {
          Console.WriteLine(plantName + " is now having a growth spurt!");
        }
        else if (PlantMakeup.CareStats["water"] == 4 && PlantMakeup.CareStats["sun"] == 3 && PlantMakeup.CareStats["weed"] == 2 && PlantMakeup.CareStats["feed"] == 2)
        {
          Console.WriteLine(plantName + " is now flowering!");
        }
        else if (PlantMakeup.CareStats["health"] == 5)
        {
          Console.WriteLine(plantName + " is wilting!");
        }
        else if (PlantMakeup.CareStats["health"] == 0)
        {
          Console.WriteLine(plantName + " is dead!");
          break;
        }
       
        
        
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("What action do you want to do?");
        Console.WriteLine("water || feed || sunshine || weed || read || quit");
        action = Console.ReadLine();
      }


    }
  }
}
// public -> the access modifier (default is 'internal'), labels how this method is accessed. Public allows any part of internal or external code to access it.
// static -> allows access without instantiating the class, for example Main() must be static as Program can't be instantiated
// void -> return data type, void denotes returning nothing (i.e. no 'return' statement in the method), it can be any data type (string, int, int[](array of ints), bool, etc) but there can only be one return type
// Main() -> name of the method