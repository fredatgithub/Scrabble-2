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
    public void ScrabbleValue_ReturnedSingleValueOne_singleValueOne()
    {
      Scrabble testScrabble = new Scrabble("ad");
      int expected = 1;
      int output = testScrabble.ScrabbleValues();
      Assert.Equal(expected, output);
    }
  }
}
