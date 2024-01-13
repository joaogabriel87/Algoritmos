using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pesquisa Binaria
{
    public class Exercicio 2
    {
        
    public int CountNegatives(int[][] grid)
{
    int neg = 0;
    for (int i = 0; i < grid.Length; i++)
    {
        for (int j = 0; j < grid[i].Length; j++)
        {
            if (grid[i][j] < 0)
            {
                neg++;
            }
        }
    }
    return neg;
}
}
    }
