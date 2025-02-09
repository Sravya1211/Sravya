namespace GradeProcessor.Tests
{
    public class GradeProcessorTests
    {
        [Fact]
        public void CalculateAverage_ShouldReturnCorrectAverage()
        {
            List<int> grades = new List<int> { 80, 90, 100 };
            double result = GradeProcessor.Core.GradeProcessor.CalculateAverage(grades);
            Assert.Equal(90.0, result, 1);
        }

        [Fact]
        public void CalculateAverage_ShouldHandleEmptyList()
        {
            List<int> grades = new List<int> { };
            Assert.Throws<System.ArgumentException>(() => GradeProcessor.Core.GradeProcessor.CalculateAverage(grades));
        }

        [Fact]
        public void CalculateMaxGrade_ShouldReturnHighestValue()
        {
            List<int> grades = new List<int> { 70, 85, 90, 95 };
            int result = GradeProcessor.Core.GradeProcessor.CalculateMaxGrade(grades);
            Assert.Equal(95, result);
        }

        [Fact]
        public void CalculateMaxGrade_ShouldHandleEmptyList()
        {
            List<int> grades = new List<int> { };
            Assert.Throws<System.ArgumentException>(() => GradeProcessor.Core.GradeProcessor.CalculateMaxGrade(grades));
        }

        [Fact]
        public void CalculateMedianGrade_ShouldReturnCorrectMedian_OddCount()
        {
            List<int> grades = new List<int> { 70, 85, 90 };
            double result = GradeProcessor.Core.GradeProcessor.CalculateMedianGrade(grades);
            Assert.Equal(85, result);
        }

        [Fact]
        public void CalculateMedianGrade_ShouldReturnCorrectMedian_EvenCount()
        {
            List<int> grades = new List<int> { 70, 85, 90, 95 };
            double result = GradeProcessor.Core.GradeProcessor.CalculateMedianGrade(grades);
            Assert.Equal(87.5, result);
        }

        [Fact]
        public void CalculateMedianGrade_ShouldHandleEmptyList()
        {
            List<int> grades = new List<int> { };
            Assert.Throws<System.ArgumentException>(() => GradeProcessor.Core.GradeProcessor.CalculateMedianGrade(grades));
        }
    }
}
