using Nancy;
using DayCalculatorNS.Objects;
using System.Collections.Generic;
using System;

namespace DayCalculatorNS
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        string results = "";
        return View["index.cshtml", results];
      };
      Post["/"] = _ => {
        DayCalculator newNameOfDate = new DayCalculator(Request.Form["new-input1"], Request.Form["new-input2"], Request.Form["new-input3"]);
        string results = newNameOfDate.DayName();
        return View["index.cshtml", results];
      };
    }
  }
}
