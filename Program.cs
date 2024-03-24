using System;

namespace Initial_project
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Średnia z [1, 2, 3, 4]: ");
            Console.Write(average(new int[] {1, 2, 3, 4}));
            
            Console.WriteLine();
            
            Console.Write("Max z [1, 2, 3, 4]: ");
            Console.Write(max(new int[] {1, 2, 3, 4}));
        }
        
        private static double average(int[] nubmers)
        {
            int added = 0;
            foreach (var number in nubmers)
            {
                added += number;
            }
            
           return((float)added / nubmers.Length);
        }
        
        private static int max(int[] nubmers)
        {
            int max = nubmers[0];
            foreach (var number in nubmers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            
            return max;
        }
    }
}