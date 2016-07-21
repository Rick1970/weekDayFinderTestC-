using System;

namespace WeekdayFinder.Objects
{
  public class Weekday
  {
    private int _month;
    private int _day;
    private int _year;

    public Weekday(int month, int day, int year)
    {
      _month = month;
      _day = day;
      _year = year;
    }

    public string GetInput()
    {
      return _input;
    }
    public void SetInput(string newInput)
    {
      _input = newInput;
    }

    public string DetermineWeekday()
    {
      return "Who knows??"
    }
  }
}
