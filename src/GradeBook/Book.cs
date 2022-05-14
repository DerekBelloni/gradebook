using System.Collections.Generic;

namespace GradeBook
{
  class Book
  {

    public Book(string name)
    {
      grades = new List<double>();
      this.name = name;
    }
    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    public void ShowStatistics()
    {
      var sum = 0.0;
      var average = 0.0;
      var highGrade = double.MinValue;
      var lowGrade = double.MaxValue;
      foreach (double number in grades)
      {
        lowGrade = Math.Min(number, lowGrade);
        highGrade = Math.Max(number, highGrade);
        sum += number;
        average = sum / grades.Count;
      }
      Console.WriteLine($"The average grade is {average}");
      Console.WriteLine($"The lowest grade is {lowGrade}");
      Console.WriteLine($"The highest grade is {highGrade}");
    }

    private List<double> grades;
    private string name;


  }
}