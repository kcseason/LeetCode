using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
将两个有序链表合并为一个新的有序链表并返回。新链表是通过拼接给定的两个链表的所有节点组成的。 

示例：

输入：1->2->4, 1->3->4
输出：1->1->2->3->4->4

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/merge-two-sorted-lists
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
 * */
namespace _021.Merge_Two_Sorted_Lists_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l11 = new ListNode(3);
            ListNode l12 = new ListNode(16);
            ListNode l13 = new ListNode(18);
            l11.next = l12;
            l12.next = l13;

            ListNode l21 = new ListNode(1);
            ListNode l22 = new ListNode(2);
            ListNode l23 = new ListNode(3);
            ListNode l24 = new ListNode(6);
            ListNode l25 = new ListNode(8);
            ListNode l26 = new ListNode(9);
            l21.next = l22;
            l22.next = l23;
            l23.next = l24;
            l24.next = l25;
            l25.next = l26;

            ListNode nd = new Solution().MergeTwoLists(l11, l21);
            Console.Write(nd.val + " ");
            while (nd.next != null)
            {
                Console.Write(nd.next.val + " ");
                nd = nd.next;
            }

            Console.ReadLine();
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    //[3,16,18]
    //[1,2,5,6,7,8]
    //[1,2,3,5,6,7,8,16,18]
    //public class Solution
    //{
    //    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    //    {
    //        ListNode head = l1 == null ? l2 : l1;
    //        ListNode temp = null;

    //        while (l2 != null)
    //        {
    //            while (l1 != null)
    //            {
    //                if (l2.val <= l1.val)
    //                {
    //                    temp = new ListNode(l2.val);
    //                    temp.next = l1;
    //                    l1 = temp;
    //                    head = l1;
    //                    break;
    //                }

    //                if (l1.next != null && l2.val <= l1.next.val)
    //                {
    //                    temp = new ListNode(l2.val);
    //                    temp.next = l1.next;
    //                    l1.next = temp;
    //                    break;
    //                }
    //                if (l1.next == null)
    //                {
    //                    temp = new ListNode(l2.val);
    //                    l1.next = temp;
    //                    break;
    //                }

    //                l1 = l1.next;
    //            }

    //            l2 = l2.next;
    //        }

    //        return head;
    //    }
    //}

    public class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;
            if (l1.val < l2.val)
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeTwoLists(l1, l2.next);
                return l2;
            }
        }
    }

    public class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;


        }
    }
}
