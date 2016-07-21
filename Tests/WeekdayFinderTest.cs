using System.Collections.Generic;
using Xunit;
using System;

namespace WeekdayFinder.Objects
{
  public class WeekdayFinderTest
  {
    [Fact]
    public void T1_DetermineWeekday_GetWeekdayToday_Thursday()
    {
      Weekday testWeekday = new Weekday(7, 21, 2016);
      Assert.Equal("Thursday", testWeekday.DetermineWeekday().ToString());
    }
    [Fact]
    public void T2_DetermineWeekday_GetWeekdayOneYearAgoToday_Tuesday()
    {
      Weekday testWeekday = new Weekday(7, 21, 2015);
      Assert.Equal("Tuesday", testWeekday.DetermineWeekday().ToString());
    }
  }
}
