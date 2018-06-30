using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graderanker
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(87.5f);
            book.AddGrade(56);
            book.AddGrade(24);
            GradeStatistics stats = book.ComputeStatistics();

            GradeBook book2 = book;
            book2.AddGrade(67);

            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.AverageGrade);

        }
    }
}
