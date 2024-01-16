using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tabelas Hash
{
    public class Exercicio 3
    {
         public string DecodeMessage(string key, string message)
{
    var decoder = new char[128];

    decoder[' '] = ' ';

    var alphabet = 'a';

    foreach (var c in key)
        if (decoder[c] == 0)
            decoder[c] = alphabet++;

    return string.Concat(message.Select(_ => decoder[_]));
}
}
}