using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tabelas Hash
{
    public class Exercicio 1
    {
         public int NumJewelsInStones(string jewels, string stones)
{
    int gems = 0;

    foreach (char c in stones)
    {
        if (jewels.Contains(c))
            gems++;
    }

    return gems;
}
}
}