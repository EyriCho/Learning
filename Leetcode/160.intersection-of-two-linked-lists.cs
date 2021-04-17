/*
 * @lc app=leetcode id=160 lang=csharp
 *
 * [160] Intersection of Two Linked Lists
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        ListNode nodeA = headA, nodeB = headB;
        int countA = 0, countB = 0;
        while (nodeA != null)
        {
            nodeA = nodeA.next;
            countA++;
        }
        while (nodeB != null)
        {
            nodeB = nodeB.next;
            countB++;
        }
        nodeA = headA;
        nodeB = headB;
        var node = countA > countB ? headA : headB;
        var diff = Math.Abs(countA - countB);
        if (countA > countB)
        {
            while (diff-- > 0)
                nodeA = nodeA.next;
        }
        else
        {
            while (diff-- > 0)
                nodeB = nodeB.next;
        }
        
        while (nodeA != null)
        {
            if (nodeA == nodeB)
                return nodeA;
            
            nodeA = nodeA.next;
            nodeB = nodeB.next;
        }
        return null;
    }
}
// @lc code=end

