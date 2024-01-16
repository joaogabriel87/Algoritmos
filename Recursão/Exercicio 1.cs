using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recursão
{
    public class Exercicio 1
    {
         public ListNode ReverseList(ListNode head)
    {
        ListNode cur = head;
        ListNode prev = null;
        ListNode nxt = null;
        while (cur != null)
        {
            nxt = cur.next;
            cur.next = prev;
            prev = cur;
            cur = nxt;
        }

        return prev;
    }
}
}