using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTwoNumsOfTarget
{
    internal class Program
    {
        // The time complexity of this function is O(n) because it uses a HashSet to store the values
        // and check if the difference between the current value and the target sum is in that HashSet.
        // The space complexity is also O(n) because it uses a HashSet to store the values.

        static void Main(string[] args)
        {
            Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
            Console.WriteLine(indices.Item1 + " " + indices.Item2);

        }
        public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
        {
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < list.Count; i++)
            {
                var needed = sum - list[i];
                if (hs.Contains(needed))
                {
                    return Tuple.Create(list.IndexOf(needed), i);
                }
                hs.Add(list[i]);
            }
            return null;
        }
    }
}
