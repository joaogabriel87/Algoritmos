using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Array e Lista Encadeadas
{
    public class Exercicio 3
    {
        public int NumIdenticalPairs(int[] nums)
{
    int count = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] == nums[j])
            {
                count++;
            }
        }
    }
    return count;
}
}
}