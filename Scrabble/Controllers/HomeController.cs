using Microsoft.AspNetCore.Mvc;
using Scrabble.Models;
using System.Collections.Generic;

namespace Scrabble.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/score")]
    public ActionResult Score()
    {
      string newWord = Request.Form["word"];

      ScrabbleGame newGame = new ScrabbleGame(newWord);

      return View(newGame);
    }
  }
}
