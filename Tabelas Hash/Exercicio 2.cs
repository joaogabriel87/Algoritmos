using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tabelas Hash
{
    public class Exercicio 2
    {
         public int[] SmallerNumbersThanCurrent(int[] nums)
{
    var list = nums.ToList();

    list.Sort();

    var res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = list.IndexOf(nums[i]);
    }

    return res;
}
}
}