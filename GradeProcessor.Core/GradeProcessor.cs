namespace GradeProcessor.Core
{
    public class GradeProcessor
    {
        public static double CalculateAverage(List<int> grades)
        {
            if (grades.Count == 0)
            {
                throw new ArgumentException("Empty List");
            }
            return grades.Average();
        }

        public static int CalculateMaxGrade(List<int> grades)
        {
            if (grades.Count == 0)
            {
                throw new ArgumentException("Empty List");
            }
            return grades.Max();
        }

        public static double CalculateMedianGrade(List<int> grades)
        {
            if (grades.Count == 0)
            {
                throw new ArgumentException("Empty List");
            }

            grades.Sort();
            int count = grades.Count;
            int mid = count / 2;

            if (count % 2 == 0) // Even count, average the middle two
            {
                return (grades[mid - 1] + grades[mid]) / 2.0;
            }
            else // Odd count, take the middle element
            {
                return grades[mid];
            }
        }
    }
}

