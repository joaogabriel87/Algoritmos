using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Array e Lista Encadeadas
{
    public class Exercicio 2
    {
        public int[] BuildArray(int[] nums)
{
    int[] arr = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        arr[i] = nums[nums[i]];
    }

    return arr;
}
}
}