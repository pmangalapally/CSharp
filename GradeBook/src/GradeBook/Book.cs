using System.Collections.Generic;
using System;

namespace GradeBook
{
    class Book
    {
        //Constructor
        public Book (string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrades (double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics ()
        {
            var result = 0.0;
            var HighGrade = double.MinValue;
            var LowGrade = double.MaxValue;

            foreach (double grade in grades)
            {
                result += grade;
                HighGrade = Math.Max(grade, HighGrade);
                LowGrade = Math.Min(grade, LowGrade);
            }
            var averageGrade = result/grades.Count;
            //var averageGrade = result/3;
            Console.WriteLine($"Maximum grade is {HighGrade}");
            Console.WriteLine($"Minimum grade is {LowGrade}");
            Console.WriteLine($"Average grade is {averageGrade}");

        }
        private string name;
        private List <double> grades;

    }
}