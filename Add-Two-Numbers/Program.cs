using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Add_Two_Numbers
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
            ListNode l1 = new ListNode(2);
            ListNode l2 = new ListNode(4);
            ListNode l3 = new ListNode(9);
            ListNode l10 = new ListNode(9);
            ListNode l11 = new ListNode(9);
            ListNode l12 = new ListNode(9);
            ListNode l13 = new ListNode(9);

            ListNode l4 = new ListNode(5);
            ListNode l5 = new ListNode(6);
            ListNode l6 = new ListNode(4);
            ListNode l8 = new ListNode(9);

            l1.next = l2;
            l2.next = l3;
            l3.next = l10;
            l10.next = l11;
            l11.next = l12;
            l12.next = l13;

            l4.next = l5;
            l5.next = l6;
            l6.next = l8;

            ListNode l7 = AddTwoNumbers(l1,l4);
            while (l7 != null)
            {
                Console.WriteLine(l7.val);
                l7 = l7.next;
            }
        }

        static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode current1 = l1;
            ListNode current2 = l2;
            int c1 = 0;
            int c2 = 0;
            bool needsCarry = false;


            while (current1 != null)
            {
                c1++;
                current1 = current1.next;
            }

            while (current2 != null)
            {
                c2++;
                current2 = current2.next;
            }

            current1 = l1;
            current2 = l2;

            ListNode zero = new ListNode(0);
            ListNode dummy = new ListNode(0);
            ListNode currentResult = dummy;
            while (c1 > 0 || c2 > 0 || needsCarry)
            {
                if (current1 != null &&current1.next == null)
                {
                    current1.next = zero;
                }
                else if (current2 != null && current2.next == null)
                {
                    current2.next = zero;
                }
                else if (current1 != null && current2 != null &&current1.next == null && current2.next == null && needsCarry)
                {
                    current1.next = zero;
                    current2.next = zero;
                }

                int v1 = 0;
                int v2 = 0;

                if (current1 != null)
                {
                    v1 = current1.val;
                }

                if (current2 != null)
                {
                    v2 = current2.val;
                }

                int sum = v1 + v2;

                if (needsCarry)
                {
                    sum++;
                    needsCarry = false;
                }

                if (sum < 10)
                {
                    currentResult.next = new ListNode(sum);
                    needsCarry = false;
                }
                else
                {
                    currentResult.next = new ListNode(sum % 10);
                    needsCarry = true;
                }
                currentResult = currentResult.next;


                if (current1 != null)
                {
                    current1 = current1.next;
                }

                if (current2 != null)
                {
                    current2 = current2.next;
                }


                c1--;
                c2--;
            }
            return dummy.next;
        }
    }
}
