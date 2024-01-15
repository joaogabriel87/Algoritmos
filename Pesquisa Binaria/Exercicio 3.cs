using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pesquisa Binaria
{
    public class Exercicio 3
    {
        public int[] Intersection(int[] nums1, int[] nums2)
{
    List<int> ansList = new List<int>();

    for (int i = 0; i < nums1.Length; i++)
    {
        for (int j = 0; j < nums2.Length; j++)
        {
            if (nums1[i] == nums2[j])
            {
                if (!ansList.Contains(nums1[i]))
                {
                    ansList.Add(nums1[i]);
                }
                break;
            }
        }
    }

    return ansList.ToArray();
}
}
}