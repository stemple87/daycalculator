using System.Collections.Generic;
using System.Globalization;
using Xunit;
namespace DayCalculatorNS.Objects

{
  public class DayCalculatorTest
  {
    [Fact]
    public void Test1_ToCheckTheDayName_ReturnMonday()
    {
      // //Arrange
      int input1 = 15;
      int input2 = 2;
      int input3 = 2016;

      DayCalculator testDayCalculator = new DayCalculator(input1, input2, input3);
      //
      // //Act
      var result = testDayCalculator.DayName();
      //
      //Assert
      Assert.Equal("Monday", result);
    }
  }
}
