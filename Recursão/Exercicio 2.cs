using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recursão
{
    public class Exercicio 2
    {
     public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null && list2 == null)
        {
            return list2;
        }
        ListNode current = new ListNode(0);
        ListNode head = current;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }

        if (list1 != null)
        {
            current.next = list1;
        }

        if (list2 != null)
        {
            current.next = list2;
        }

        return head.next;


    }
}
}