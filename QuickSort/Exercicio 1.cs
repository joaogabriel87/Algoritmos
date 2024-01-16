using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickSort
{
    public class Exercicio 1
    {
         public TreeNode SortedArrayToBST(int[] nums)
    {
        return CreateNode(0, nums.Length - 1);

        TreeNode CreateNode(int left, int right)
        {
            if (left > right)
            {
                return null;
            }
            int mid = left + (right - left) / 2;
            return new TreeNode(nums[mid], CreateNode(left, mid - 1), CreateNode(mid + 1, right));
        }
    }
}
}