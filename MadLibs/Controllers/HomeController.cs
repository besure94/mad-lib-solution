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
    public ActionResult Story(string noun, string adverb, string adjective, string secondNoun, string exclamation, string SecondAdverb, string ThirdNoun)
    {
      MadLibVariable myMadLibVariable = new MadLibVariable();
      myMadLibVariable.Noun = noun;
      myMadLibVariable.Adverb = adverb;
      myMadLibVariable.Adjective = adjective;
      myMadLibVariable.SecondNoun = secondNoun;
      myMadLibVariable.Exclamation = exclamation;
      myMadLibVariable.SecondAdverb = SecondAdverb;
      myMadLibVariable.ThirdNoun = ThirdNoun;
      return View(myMadLibVariable);
    }
  }
}