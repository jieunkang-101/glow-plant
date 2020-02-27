using System;
using System.Collections.Generic;
using Action.Models;

namespace PlantCare 
{
  public class Program
  {
    public static List<Plants> PlantList = new List<Plants>(){};

    public static void Main()
    {
      Console.WriteLine("Welcome to the Plant Grow Database!");
      Console.WriteLine("Enter the name of your new plant: ");
      string name = Console.ReadLine();
      Console.WriteLine("Does this plant enjoy the sunshine? [Y or N]");
      string type = Console.ReadLine();
      Console.WriteLine("How many hours a day is your plant in the sun?");
      string stringSunshine = Console.ReadLine());
      int sunshine = int.Parse(stringSunshine);
      Console.WriteLine("How many inches tall is your plant?");
      string stringHeight = Console.ReadLine();
      int height = int.Parse(stringHeight);
      Console.WriteLine("On a scale of 1-100, how healthy is your plant?");
      string stringHealth = Console.ReadLine();
      int health = int.Parse(stringHealth);
      Console.WriteLine("How much water do you give the plant a week?");
      int water = int.Parse(Console.ReadLine());
      Console.WriteLine("How many times do you apply fertilize a month?");
      int feed = int.Parse(Console.ReadLine());

      Plants userPlant = new Plants(name, type, height, health, water, feed, sunshine);
      userPlant.GrowPlants();
      PlantList.Add(userPlant);
      Console.WriteLine(userPlant.Name);
      ShowPlants();
      AddAction();
    }

    public static void AddAction()
    {
      Console.WriteLine("Would you like to Keep caring your plants or Add new plant or finish? [keep/ add/ finish]");
      string actionResponse = Console.ReadLine();
      
      if (actionResponse == "keep")
      {
        Console.WriteLine("Which plant would you like to Care for?");
        string searchName = Console.ReadLine();
        foreach (Plants foliage in PlantList)
        {
          if (foliage.Name == searchName)
            {
              Console.WriteLine("\n--------------------------");
              Console.WriteLine("How much water do you give the plant a week?");
              int water = int.Parse(Console.ReadLine());
              Console.WriteLine("How many times do you apply fertilize a month?");
              int feed = int.Parse(Console.ReadLine());
              foliage.GrowPlants();
              ShowPlants();
              AddAction();
            }
        }    
      }
      else if (actionResponse == "add")
      {
        Main();
      }
      else if(actionResponse == "finish")
      {
        Console.WriteLine("Goodbye.");
      }
      else 
      {
        Console.WriteLine("Please enter keep, add or finish.\n");
        AddAction();
      }
    }

    public static void ShowPlants()
    {
      foreach (Plants foliage in PlantList)
      {
        Console.WriteLine("\n--------------------------");
        Console.WriteLine($"Name: {foliage.Name}");
        Console.WriteLine($"Height: {foliage.Height}");
        Console.WriteLine($"Health: {foliage.Health}\n");
      }
    }
  }
}