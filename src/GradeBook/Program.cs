// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace GradeBook
{

  class Program
  {
    static void Main(string[] args)
    {

      List<double> grades = new List<double>() { 12.7, 10.9, 9.5 };
      grades.Add(56.1);


      var sum = 0.0;
      var average = 0.0;
      foreach (double number in grades)
      {
        sum += number;
        average = sum / grades.Count;
      }
      System.Console.WriteLine(sum);
      System.Console.WriteLine($"The average grade is {average}");
      if (args.Length > 0)
      {
        Console.WriteLine($"Hello, {args[0]}!");
      }
      else
      {
        Console.WriteLine("Hello!");
      }
    }
  }
}




