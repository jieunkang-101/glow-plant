using System;
using System.Collections.Generic;
namespace Action.Models
{
  public class Plants 
  {
    public string Name { get; set; }
    public string Type { get; set; }
    public int Height { get; set; }
    public int Health  { get; set; }
    public int Water { get; set; }
    public int Feed { get; set; }
    public int Sunshine { get; set; }

   

    public Plants(string name, string type, int height, int health, int water, int feed, int sunshine)
    {
      Name = name;
      Type = type;
      Height = height;
      Health = health;
      Water = water;
      Feed = feed;
      Sunshine = sunshine;
    }
    // public void AddList(string name, string type, int height, int health, int water, int feed, int sunshine)
    // {
    //   PlantList.Add(new PlantList { Name = name, Type = type, Height = height, Water = water, Feed = feed, Sunshine = sunshine});
    // }
    // public void AddList()
    // {
    //   List<Plants> PlantList = new List<Plants>(){};
    //   newPlant = new Plants();
    //   newPlant.Name = name;
    //   newPlant.Type = type;
    //   newPlant.Height = height;
    //   newPlant.Health = health;
    //   newPlant.Water = water;
    //   newPlant.Feed = feed;
    //   newPlant.Sunshine = sunshine;
    //   PlantList.Add(newPlant);

     
    //   Console.WriteLine(P);
    // }

    public void GrowPlants()
    {
      WaterAmount(Water);
      FeedAmount(Feed);
      SunshineHours(Type, Sunshine);
    }

    private void WaterAmount(int water)
    {
      if (water > 5) 
      {
        Height++;
        Health++;
      }
      else
      {
        Health--;
      }
    }

    private void FeedAmount(int feed)
    {
      if (feed > 1)
      {
        Health++;
      }
      else
      {
        Health--;
      }
    }

    private void SunshineHours(string type, int sunshine)
    {
      if (type == "Y" && sunshine > 7 ) 
      {
        Height++;
        Health++;
      }
      else if (type == "Y" && sunshine <= 7 )
      {
        Health--;
      }
      else if (type == "N" && sunshine < 3 )
      {
        Health++;
      }
      else if (type == "N" && sunshine >= 3 )
      {
        Health--;
      }
    }
    
  }
}