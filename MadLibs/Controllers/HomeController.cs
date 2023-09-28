using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Intro() { return View(); }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/story")]
    public ActionResult Story(string noun, string adjective, string exclamation, string adverb, string secondNoun)
    {
      MadLibVariable myMadLibVariable = new MadLibVariable();
      myMadLibVariable.Noun = noun;
      myMadLibVariable.Adjective = adjective;
      myMadLibVariable.Exclamation = exclamation;
      myMadLibVariable.Adverb = adverb;
      myMadLibVariable.SecondNoun = secondNoun;
      return View(myMadLibVariable);
    }
  }
}