using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pesquisa em Larguras
{
    public class Exercicio 1
    {
         public int RangeSumBST(TreeNode root, int low, int high)
{
    int sum = 0;
    if (root == null)
        return sum;
    if (root.val >= low && root.val <= high)
        sum += root.val;
    if (root.val > low)
        sum += RangeSumBST(root.left, low, high);
    if (root.val < high)
        sum += RangeSumBST(root.right, low, high);
    return sum;
}
}
}