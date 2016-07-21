using System.Collections.Generic;
using Xunit;

namespace WeekdayFinder.Objects
{
  public class WeekdayFinderTest
  {
    [Fact]
    public void T1_DetermineWeekday_GetWeekdayToday_Thursday()
    {
      Weekday testWeekday = new Weekday(7, 21, 2016);
      Assert.Equal("Thursday", testWeekday.DetermineWeekday());
    }
  }
}
