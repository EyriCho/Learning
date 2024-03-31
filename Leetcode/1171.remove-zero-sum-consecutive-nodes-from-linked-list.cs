/*
 * @lc app=leetcode id=1171 lang=csharp
 *
 * [1171] Remove Zero Sum Consecutive Nodes from Linked List
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
    public ListNode RemoveZeroSumSublists(ListNode head) {
        ListNode faked = new (0, head),
            node = faked,
            prev = null,
            toRemove = null;
        int sum = 0,
            tempSum = 0;
        Dictionary<int, ListNode> dict = new ();

        while (node != null)
        {
            sum += node.val;
            if (dict.ContainsKey(sum))
            {
                prev = dict[sum];
                toRemove = prev.next;
                tempSum = sum;
                while (toRemove != node)
                {
                    tempSum += toRemove.val;
                    dict.Remove(tempSum);
                    toRemove = toRemove.next;
                }
                prev.next = node.next;
            }
            else
            {
                dict[sum] = node;
            }
            node = node.next;
        }

        return faked.next;
    }
}
// @lc code=end

