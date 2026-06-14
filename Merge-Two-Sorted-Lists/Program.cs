using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Two_Sorted_Lists
{
    internal class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        static void Main(string[] args)
        {
            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(4);

            node1.next = node2;
            node2.next = node3;

            ListNode node10 = new ListNode(1);
            ListNode node11 = new ListNode(3);
            ListNode node12 = new ListNode(4);

            node10.next = node11;
            node11.next = node12;

            ListNode result = MergeTwoLists(node1, node10);

        }

        static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            List<int> test = new List<int>();

            while (list1 != null) { test.Add(list1.val); list1 = list1.next; }
            while (list2 != null) { test.Add(list2.val); list2 = list2.next; }

            test.Sort();

            ListNode dummy = new ListNode(0);
            ListNode current = dummy;

            foreach (int i in test)
            {
                current.next = new ListNode(i);
                current = current.next;
            }

            return dummy.next;
        }
    }
}
