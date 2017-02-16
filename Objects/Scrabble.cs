using Nancy;
using System;
using System.Collections.Generic;

namespace ScrabbleValueFinder.Objects
{
  public class Scrabble
  {
    private string _wordInput;
    private int _score;
    char[] _wordLetterArray;

    //"Scrabble" in the next line is a constructor (doesn't take its name from the class)
    public Scrabble (string wordInput)
    {
      _wordInput = wordInput;
      _wordLetterArray = _wordInput.ToCharArray();

      Console.WriteLine(_wordLetterArray[0]);
    }

    public string GetWord()
    {
      return _wordInput;
    }

    public int ScrabbleValues()
    {
      _score = 0;
      char[] onePointArray = {'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't'};
      char[] twoPointArray = {'d', 'g'};
      for (int i = 0; i <= _wordLetterArray.Length-1; i++)
      {
        for (int j = 0; j <= onePointArray.Length-1; j++)
        {
          if (_wordLetterArray[i] == onePointArray[j])
          {
            _score += 1;
          }
        }
        for (int k = 0; k <= twoPointArray.Length-1; k++)
        {
          if (_wordLetterArray[i] == twoPointArray[k])
          {
            _score += 2;
            Console.WriteLine(_score);
          }
        }
      }
      return _score;
    }
  }



}
