using System;

namespace Task5
{
    public class Program
    {
        public static double GetAverage(int[] marks)
        {
            if (marks.Length == 0) return 0;
            int sum = 0;
            foreach (int m in marks) sum += m;
            return (double)sum / marks.Length;
        }

        public static int GetMin(int[] marks)
        {
            int min = marks[0];
            foreach (int m in marks)
                if (m < min) min = m;
            return min;
        }

        public static int GetMax(int[] marks)
        {
            int max = marks[0];
            foreach (int m in marks)
                if (m > max) max = m;
            return max;
        }

        public static void PrintGroupStatistics(int[][] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                int[] group = groups[i];
                Console.WriteLine($"Група {i + 1}: Середній = {GetAverage(group):F2}, Мінімальний = {GetMin(group)}, Максимальний = {GetMax(group)}");
            }
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[][] groups = new int[][]
            {
                new int[] {100, 95, 80, 70, 90},
                new int[] {60, 75, 50, 85, 95},
                new int[] {100, 100, 95, 90, 96}
            };

            PrintGroupStatistics(groups);
        }
    }
}
