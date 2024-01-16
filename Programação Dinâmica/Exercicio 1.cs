using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programação Dinâmica
{
    public class Exercicio 1
    {
        public int[] CountBits(int n)
{
    if (n < 1) return new int[] { 0 };

    int[] op = new int[n + 1];
    op[1] = 1;
    int pivot = 2;

    for (int i = 2; i <= n; i++)
    {
        if (i == 2 * pivot) pivot *= 2;

        op[i] = 1 + op[i - pivot];
    }

    return op;
}
}
}