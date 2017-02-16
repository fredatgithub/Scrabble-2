using Nancy;
using System;
using System.Collections.Generic;

namespace ScrabbleValueFinder.Objects
{
  public class Scrabble
  {
    private string _wordInput;

    //"Scrabble" in the next line is a constructor (doesn't take its name from the class)
    public Scrabble (string wordInput)
    {
      _wordInput = wordInput;
    }
    public string ScrabbleValues()
    {
      return _wordInput;
    }
  }

}
