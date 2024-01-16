using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programação Dinâmica
{
    public class Exercicio 3
    {
        public int Fib(int n)
{
    if (n <= 1) return n;
    int F0 = 0;
    int F1 = 1;
    for (int i = 2; i <= n; i++)
    {
        int Fn = F1 + F0;
        F0 = F1;
        F1 = Fn;
    }
    return F1;
}
}
}