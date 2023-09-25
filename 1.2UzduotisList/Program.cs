using System.Diagnostics.CodeAnalysis;

namespace _1._2UzduotisList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = new List<int>();

            for (int i = 1; i <= 50; i++)
            {
                elements.Add(i);
            }

            int result = CountAverage(elements);
            Console.WriteLine(result);
        }
        public static int CountAverage(List<int> elements)
        {
            int sum = 0;
            for (int i = 0; i < elements.Count; i++)
            {
                sum += elements[i];
            }
            return sum/ elements.Count;
        }
    }
}


