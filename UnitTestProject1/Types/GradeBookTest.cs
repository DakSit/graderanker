using graderanker;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class GradeBookTest
    {

        [TestMethod]
        public void ComputesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(87.5f);
            book.AddGrade(56);
            book.AddGrade(24);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(91, result.LowestGrade);
        }

        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(87.5f);
            book.AddGrade(56);
            book.AddGrade(24);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(24, result.LowestGrade);
        }

        [TestMethod]
        public void ComputesAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(87.5f);
            book.AddGrade(56);
            book.AddGrade(24);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(84, result.LowestGrade);
        }
    }
}
