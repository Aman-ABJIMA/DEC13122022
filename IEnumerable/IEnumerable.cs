using System;
namespace ENUMERABLE
{
    class IEnumerable
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int i = 0;
            while (i < 50)
            {
                if (i % 2 != 0)
                    numbers.Add(i);
                i++;
            }
            IEnumerable<int> t = (IEnumerable<int>)numbers;
            foreach (int n in t)
            {
                Console.WriteLine(n);
            }
        }


    }
}