using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
给出两个 非空 的链表用来表示两个非负的整数。其中，它们各自的位数是按照 逆序 的方式存储的，并且它们的每个节点只能存储 一位 数字。

如果，我们将这两个数相加起来，则会返回一个新的链表来表示它们的和。

您可以假设除了数字 0 之外，这两个数都不会以 0 开头。

示例：

输入：(2 -> 4 -> 3) + (5 -> 6 -> 4)
输出：7 -> 0 -> 8
原因：342 + 465 = 807

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/add-two-numbers
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
 **/

namespace _002.Add_Two_Numbers_M_
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l11 = new ListNode(2);
            ListNode l12 = new ListNode(4);
            ListNode l13 = new ListNode(3);
            l11.next = l12;
            l12.next = l13;

            ListNode l21 = new ListNode(5);
            ListNode l22 = new ListNode(6);
            ListNode l23 = new ListNode(9);
            l21.next = l22;
            l22.next = l23;

            ListNode nd = new Solution().AddTwoNumbers(l11, l21);
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

    //Input: (2 -> 4 -> 3) + (5 -> 6 -> 9)
    //Output: 7 -> 0 -> 3 -> 1  342+965=1307

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = null;
            ListNode temp = null;
            var nextPlusVl = 0;

            while (l1 != null || l2 != null)
            {
                // 计算两数之和 并加上前一轮需要进位的值
                var val = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + nextPlusVl;
                nextPlusVl = val / 10; // 计算个位

                var newNode = new ListNode(val % 10); // 计算十位并赋值
                if (head == null)
                    temp = head = newNode;
                else
                    temp.next = newNode; 
                temp = newNode; // 临时节点不断递进, head节点接受temp的next节点，但不会变成新的temp节点
                // l1 l2 指向自己在链表中对应的下一个值
                l1 = l1 == null ? l1 : l1.next;
                l2 = l2 == null ? l2 : l2.next;
            }

            if (nextPlusVl > 0)
                temp.next = new ListNode(nextPlusVl);

            return head;
        }
    }
}
