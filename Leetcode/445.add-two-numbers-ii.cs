/*
 * @lc app=leetcode id=445 lang=csharp
 *
 * [445] Add Two Numbers II
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode Reverse(ListNode node)
        {
            var temp = new ListNode();
            while (node != null)
            {
                var next = node.next;
                node.next = temp.next;
                temp.next = node;
                node = next;
            }

            return temp.next;
        }

        ListNode r1 = Reverse(l1), r2= Reverse(l2);

        var carry = 0;
        var t = new ListNode();
        var n = t;
        while (r1 != null && r2 != null)
        {
            var digit = r1.val + r2.val + carry;
            carry = digit / 10;
            digit %= 10;
            n.next = new ListNode(digit);
            n = n.next;
            r1 = r1.next;
            r2 = r2.next;
        }

        while (r1 != null)
        {
            var digit = r1.val + carry;
            carry = digit / 10;
            digit %= 10;
            n.next = new ListNode(digit);
            n = n.next;
            r1 = r1.next;
        }

        while (r2 != null)
        {
            var digit = r2.val + carry;
            carry = digit / 10;
            digit %= 10;
            n.next = new ListNode(digit);
            n = n.next;
            r2 = r2.next;
        }

        if (carry > 0)
        {
            n.next = new ListNode(1);
        }

        return Reverse(t.next);
    }
}
// @lc code=end

