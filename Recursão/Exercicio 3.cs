using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recursão
{
    public class Exercicio 3
    {
         public bool IsPalindrome(ListNode head)
    {
        var number = 0;
        var reverted = 0;
        var mul = 1;
        while (head != null)
        {
            number = number * 10 + head.val;
            reverted += head.val * mul;
            mul *= 10;
            head = head.next;
        }
        return number == reverted;
    }
}
}