using Nancy;
using ScrabbleValueFinder.Objects;
using System.Collections.Generic;


namespace ScrabbleValueFinder
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Post["/results"] = _ => {
        string inputtedWord = Request.Form["word"];
        Scrabble newScrabble = new Scrabble(inputtedWord);
        //The following methods are not called because they are already inherently available when you create a new instance of Scrabble. We will call the methods on the cshtml page.

        // string wordOutput = newScrabble.GetWord();
        // int scrabbleResult = newScrabble.ScrabbleValues();
        return View["results.cshtml", newScrabble];
      };
    }
  }
}
