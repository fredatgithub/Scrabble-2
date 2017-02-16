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
      char[] threePointArray = {'b', 'c', 'm', 'p'};
      char[] fourPointArray = {'f', 'h', 'v', 'w', 'y'};
      char[] fivePointArray = {'k'};
      char[] eightPointArray = {'j', 'x'};
      
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
        for (int c = 0; c <= threePointArray.Length-1; c++)
        {
          if (_wordLetterArray[i] == threePointArray[c])
          {
            _score += 3;
            Console.WriteLine(_score);
          }
        }
        for (int f = 0; f <= fourPointArray.Length-1; f++)
        {
          if (_wordLetterArray[i] == fourPointArray[f])
          {
            _score += 4;
            Console.WriteLine(_score);
          }
        }
        for (int v = 0; v <= fivePointArray.Length-1; v++)
        {
          if (_wordLetterArray[i] == fivePointArray[v])
          {
            _score += 5;
            Console.WriteLine(_score);
          }
        }
        for (int b = 0; b <= eightPointArray.Length-1; b++)
        {
          if (_wordLetterArray[i] == eightPointArray[b])
          {
            _score += 8;
            Console.WriteLine(_score);
          }
        }
      }
      return _score;
    }
  }



}
