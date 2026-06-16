using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Delete_the_Middle_Node_of_a_Linked_List
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
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(5);
            ListNode l3 = new ListNode(4);
            ListNode l4 = new ListNode(8);
            ListNode l5 = new ListNode(9);
            ListNode l6 = new ListNode(10);

            l1.next = l2;
            //l2.next = l3;
            //l3.next = l4;
            //l4.next = l5;
            //l5.next = l6;

            DeleteMiddle(l1);
        }

        static ListNode DeleteMiddle(ListNode head)
        {
            ListNode Counter = head;
            int countereven = 0;
            bool even = false;

            while (Counter != null)
            {
                countereven++;
                Counter = Counter.next;
            }

            if (countereven % 2 == 0)
            {
                even = true;
            }

            ListNode fast = head;
            ListNode slow = head;
            int counter = 0;

            while ((fast != null && fast.next != null && fast.next.next != null) /*&& (slow != null && slow.next != null)*/)
            {
                fast = fast.next.next;
                slow = slow.next;
                counter++;
            }

            if (even)
            {
                counter++;
            }

            if (counter == 0)
            {
                return head.next;
            }

            if (head == null)
            {
                return null;
            }

            ListNode current = head;

            for (int i = 0; i < counter - 1; i++)
            {
                current = current.next;
            }

            current.next = current.next.next;

            return head;

        }
    }
}
