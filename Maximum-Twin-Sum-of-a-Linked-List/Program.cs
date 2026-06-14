using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Twin_Sum_of_a_Linked_List
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
            ListNode node1 = new ListNode(4);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(2);
            ListNode node4 = new ListNode(3);

            node1.next = node2;
            node2.next = node3;
            node3.next = node4;

            Console.WriteLine(PairSum(node1));
        }


        static int PairSum(ListNode head)
        {
            List<int> list = new List<int>();

            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }

            int max = 0;

            for (int i = 0; i < list.Count / 2; i++)
            {
                max = Math.Max(max, list[i] + list[list.Count - 1 - i]);
            }

            return max;
        }
    }
}
