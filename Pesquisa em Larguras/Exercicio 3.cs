using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pesquisa em Larguras
{
    public class Exercicio 3
    {
         public TreeNode IncreasingBST(TreeNode root)
{
    if (root == null) return null;
    if (root.left == null)
    {
        root.right = IncreasingBST(root.right);
        return root;
    }
    var left = IncreasingBST(root.left);
    var right = IncreasingBST(root.right);
    if (left != null)
    {
        var l = left;
        while (l.right != null)
        {
            l = l.right;
        }
        l.right = root;
        root.left = null;
    }
    root.right = right;
    return left;
}
}
}