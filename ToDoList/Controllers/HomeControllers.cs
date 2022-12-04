using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [Route("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [Route("/items")]
    public ActionResult Create(string description)
    {
      Item myItem = new Item(description);
      return RedirectToAction("Index");
    }

  }
}