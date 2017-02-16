using Xunit;
using System;
using System.Collections.Generic;

namespace ScrabbleValueFinder.Objects
{
  public class ScrabbleTest
  {
    [Fact]
    public void GetWord_ReturnWord_word()
    {
      Scrabble testScrabble = new Scrabble("hello");
      string expected = "hello";
      string output = testScrabble.GetWord();
      Assert.Equal(expected, output);
    }

    [Fact]
    public void ScrabbleValue_ReturnedValueOne_valueone()
    {
      Scrabble testScrabble = new Scrabble("at");
      int expected = 2;
      int output = testScrabble.ScrabbleValues();
      Assert.Equal(expected, output);
    }

    [Fact]
    public void ScrabbleValue_ReturnedValueTwo_valuetwo()
    {
      Scrabble testScrabble = new Scrabble("dot");
      int expected = 4;
      int output = testScrabble.ScrabbleValues();
      Assert.Equal(expected, output);
    }

    [Fact]
    public void ScrabbleValue_ReturnedValueThree_valuethree()
    {
      Scrabble testScrabble = new Scrabble("peed");
      int expected = 7;
      int output = testScrabble.ScrabbleValues();
      Assert.Equal(expected, output);
    }

    [Fact]
    public void ScrabbleValue_ReturnedValueFour_valuefour()
    {
      Scrabble testScrabble = new Scrabble("width");
      int expected = 12;
      int output = testScrabble.ScrabbleValues();
      Assert.Equal(expected, output);
    }
  }
}
