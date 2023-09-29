using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Home() { return View(); }

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

    [Route("/secondForm")]
    public ActionResult SecondForm() { return View(); }

    [Route("/storyTwo")]
    public ActionResult StoryTwo(string noun, string adverb, string exclamation, string secondNoun, string secondAdverb, string ThirdNoun,  string secondExclamation, string FourthNoun,  string fifthNoun)
    {
      SecondMadLibVariable mySecondMadLibVariable = new SecondMadLibVariable();
      mySecondMadLibVariable.Noun = noun;
      mySecondMadLibVariable.Adverb = adverb;
      mySecondMadLibVariable.Exclamation = exclamation;
      mySecondMadLibVariable.SecondNoun = secondNoun;
      mySecondMadLibVariable.SecondAdverb = secondAdverb;
      mySecondMadLibVariable.ThirdNoun = ThirdNoun;
      mySecondMadLibVariable.SecondExclamation = secondExclamation;
      mySecondMadLibVariable.FourthNoun = FourthNoun;
      mySecondMadLibVariable.FifthNoun = fifthNoun;
      return View(mySecondMadLibVariable);
    }

  }
}