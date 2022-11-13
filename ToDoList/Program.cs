using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Models
{
  public class Program
  {
    public static void Main()
    {
      string breakLoop = "y";
      do
      {
        Console.WriteLine("Add a task to the list:");
        string userInput = Console.ReadLine();
        Item newItem1 = new Item(userInput);
        Console.WriteLine("Do you want to keep adding a task?(Y or N): ");
        breakLoop = Console.ReadLine();
      } while(breakLoop == "Y" || breakLoop == "y");

      List<Item> result = Item.GetAll();

      foreach(Item task in result)
      {
        Console.WriteLine("Task: " + task.Description);
      }
    }
  }
}


