using System.Collections.Generic;
using Xunit;
namespace ScrabbleScoreNS.Objects
{
  public class ScrabbleScoreTest
  {
    [Fact]
    public void Test1_ToCheckTheDate_ReturnSunday()
    {
      // //Arrange
      // string input1 = "A";
      // ScrabbleScore testPoints = new ScrabbleScore(input1);
      //
      // //Act
      // string result = testPoints.GetResults();
      //
      //Assert
      Assert.Equal("sunday", result);
    }
  }
}
