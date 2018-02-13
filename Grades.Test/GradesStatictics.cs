using System;
using Xunit;
using Grades;

namespace Grades.Test
{
    public class GradesStatictics
    {
        private GradeStatistics BuildGradeStatistics()
        {
            GradeBook gradeBook = new GradeBook();

            gradeBook.AddGrade(50f);
            gradeBook.AddGrade(80f);
            gradeBook.AddGrade(100f);
            gradeBook.AddGrade(20f);

            return gradeBook.ComputeStatistics();
        }

        [Fact]
        public void ComputeLowestGrade_WithValidData_ReturnGradesAdded()
        {
            GradeStatistics statistics = BuildGradeStatistics();

            Assert.Equal(statistics.LowestGrade, 20f);
        }

        [Fact]
        public void ComputeHighestGrade_WithValidData_ReturnGradesAdded()
        {
            GradeStatistics statistics = BuildGradeStatistics();

            Assert.Equal(statistics.HighestGrade, 100f);
        }

        [Fact]
        public void ComputeAverageGradeGrade_WithValidData_ReturnGradesAdded()
        {
            GradeStatistics statistics = BuildGradeStatistics();
            Assert.Equal(statistics.AverageGrade, 62.5f);
        }
    }
}
