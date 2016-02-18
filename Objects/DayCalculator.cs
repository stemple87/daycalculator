using System.Collections.Generic;
using System.Globalization;
using System;

namespace DayCalculatorNS.Objects
{
  public class DayCalculator
  {
    private int _input1;
    private int _input2;
    private int _input3;

    public DayCalculator(int myInput1, int myInput2, int myInput3)
    {
      _input1 = myInput1;
      _input2 = myInput2;
      _input3 = myInput3;
    }

    public string DayName()
    {
      DateTime dateValue = new DateTime(_input3, _input2, _input1);
    //  dateValue = (dateValue.ToString("dddd"));
      return dateValue.ToString("dddd");
    }




  //   public Dictionary<int, string> Dictionary()
  //   {
  //     Dictionary<int, string> dictionary = new Dictionary<int, string>();
  //
  //     dictionary.Add(1, "sunday");
  //     dictionary.Add(2, "monday");
  //     dictionary.Add(3, "tuesday");
  //     dictionary.Add(4, "wednesday");
  //     dictionary.Add(5, "thursday");
  //     dictionary.Add(6, "friday");
  //     dictionary.Add(7, "saturday");
  //     Console.WriteLine(dictionary);
  //
  //     return dictionary;
  //   }
  //
  //   // public string GetResults()
  //   // {
  //   //   //code goes here//
  //   // }
  }
}
