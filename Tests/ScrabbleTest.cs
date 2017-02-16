using Xunit;
using System;
using System.Collections.Generic;

namespace ScrabbleValueFinder.Objects
{
  public class ScrabbleTest
  {
    [Fact]
    public void ScrabbleValues_ReturnWord_word()
    {
      Scrabble testScrabble = new Scrabble("hello");
      string expected = "hello";
      string output = testScrabble.ScrabbleValues();
      Assert.Equal(expected, output);
    }
  }
}
