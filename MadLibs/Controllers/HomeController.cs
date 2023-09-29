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
    public ActionResult Story(string noun, string adverb, string adjective, string secondNoun, string ThirdNoun, string exclamation, string SecondAdverb, string FourthNoun)
    {
      MadLibVariable myMadLibVariable = new MadLibVariable();
      myMadLibVariable.Noun = noun;
      myMadLibVariable.Adverb = adverb;
      myMadLibVariable.Adjective = adjective;
      myMadLibVariable.SecondNoun = secondNoun;
      myMadLibVariable.ThirdNoun = ThirdNoun;
      myMadLibVariable.Exclamation = exclamation;
      myMadLibVariable.SecondAdverb = SecondAdverb;
      myMadLibVariable.FourthNoun = FourthNoun;
      return View(myMadLibVariable);
    }

  }
}