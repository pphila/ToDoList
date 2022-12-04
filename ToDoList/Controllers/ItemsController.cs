using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collection.Generic;

namespace ToDoList.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/items")]
    public ActiuonResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    
    [HttpGet("/items")]
    public ActionResult Create(string description)
    {
      Item myItem = new Item(description);
      return RedirectToAction("Index")
    }

    [HttpPost("/items/delete")]
    public ActionResult DeleteAll()
    {
      Item.ClearAll();
      return View();
    }
  }
}