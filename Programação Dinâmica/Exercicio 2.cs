using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programação Dinâmica
{
    public class Exercicio 2
    {
         public IList<IList<int>> Generate(int numRows)
{
    IList<IList<int>> Triangle = new List<IList<int>>();

    int lastRow = 0;
    for (int i = 0; i < numRows; i++)
    {
        IList<int> Row = new List<int>();
        Row.Add(1);

        if (Triangle.Count > 0)
        {
            lastRow = i - 1;
            for (int j = 1; j < i; j++)
            {
                Row.Add(Triangle[lastRow][j - 1] + Triangle[lastRow][j]);
            }
            Row.Add(1);
        }
        Triangle.Add(Row);
    }
    return Triangle;
}
}
}