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
        int[] result = new int[2] {
            int.MaxValue,
            0
        };

        bool? vector = head.val == head.next.val ? null : (head.val < head.next.val),
            current = false;
        int
            firstPoint = -1,
            lastPoint = int.MinValue,
            prev = head.next.val;
        ListNode node = head.next.next;
        while (node != null)
        {
            current = node.val == prev ? null : (node.val > prev);
            if (vector != null && current != null &&
                vector.Value ^ current.Value)
            {
                if (firstPoint > -1)
                {
                    result[0] = int.Min(result[0], lastPoint);
                    result[1] = firstPoint;
                }
                else
                {
                    firstPoint = 0;
                }
                lastPoint = 0;
            }

            if (firstPoint > -1)
            {
                lastPoint++;
                firstPoint++;
            }
            vector = current;
            prev = node.val;
            node = node.next;
        }

        return result[1] == 0 ? new int[] { -1, -1 } : result;
    }
}
// @lc code=end

