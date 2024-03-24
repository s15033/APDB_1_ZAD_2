using System;

namespace Initial_project
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Średnia z [1, 2, 3, 4]");
            Console.WriteLine(average(new int[] {1, 2, 3, 4}));
        }
        
        public static double average(int[] nubmers)
        {
            int sum = 0;
            foreach (var number in nubmers)
            {
                sum += number;
            }
            
           return((float)sum / nubmers.Length);
        }
    }
}