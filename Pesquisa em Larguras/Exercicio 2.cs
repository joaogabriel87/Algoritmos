using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pesquisa em Larguras
{
    public class Exercicio 2
    {
    public TreeNode GetTargetCopy(TreeNode a, TreeNode b, TreeNode x)
{
    if (a is null) return a;
    if (a == x) return b;
    return GetTargetCopy(a.left, b.left, x) ?? GetTargetCopy(a.right, b.right, x);
}
}
}