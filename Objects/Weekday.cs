using System;
using System.Collections.Generic;

namespace WeekdayFinder.Objects
{
  public class Weekday
  {
    private int _month;
    private int _day;
    private int _year;
    Dictionary<int, int> monthCodes = new Dictionary<int, int>() {};
    Dictionary<int, int> yearCodes = new Dictionary<int, int>() {};
    Dictionary<int, string> weekdayCodes = new Dictionary<int, string>() {};

    public Weekday(int month, int day, int year)
    {
      _month = month;
      _day = day;
      _year = year;
      monthCodes.Add(7, 5);
      yearCodes.Add(2016, 6);
      yearCodes.Add(2015, 4);
      weekdayCodes.Add(4, "Thursday");
      weekdayCodes.Add(2, "Tuesday");
    }

    public int GetMonth()
    {
      return _month;
    }
    public void SetMonth(int newMonth)
    {
      _month = newMonth;
    }

    public int GetDay()
    {
      return _day;
    }
    public void SetDay(int newDay)
    {
      _day = newDay;
    }

    public int GetYear()
    {
      return _year;
    }
    public void SetYear(int newYear)
    {
      _year = newYear;
    }

    public string DetermineWeekday()
    {  
      int inputDay = this.GetDay();
      int monthValue = monthCodes[this.GetMonth()];
      int yearValue = yearCodes[this.GetYear()];
      int weekdayValue = (monthValue + yearValue + inputDay) % 7;

      return weekdayCodes[weekdayValue];
    }
  }
}
