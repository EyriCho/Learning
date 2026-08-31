/*
 * @lc app=leetcode id=2058 lang=csharp
 *
 * [2058] Find the Minimum and Maximum Number of Nodes Between Critical Points
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
    public int[] NodesBetweenCriticalPoints(ListNode head) {
        ListNode prev = head,
            node = head.next;
        int firstPoint = -1,
            lastPoint = -1,
            currentPos = 0;
        
        int[] result = new int[2] { int.MaxValue, -1 };
        
        while (node.next != null)
        {
            currentPos++;
            if ((node.val > prev.val && node.val > node.next.val) ||
                (node.val < prev.val && node.val < node.next.val))
            {
                if (firstPoint == -1)
                {
                    firstPoint = lastPoint = currentPos;
                }
                else
                {
                    result[0] = Math.Min(result[0], currentPos - lastPoint);
                    result[1] = currentPos - firstPoint;

                    lastPoint = currentPos;
                }
            }

            prev = node;
            node = node.next;
        }

        if (result[1] == -1)
        {
            result[0] = -1;
        }

        return result;
    }
}
// @lc code=end

