using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickSort
{
    public class Exercicio 3
    {
         public int MajorityElement(int[] nums)
    {
        return nums.GroupBy(i => i)
                .OrderByDescending(g => g.Count())
                .Take(1)
                .Select(g => g.Key)
                .First();
    }
}
}