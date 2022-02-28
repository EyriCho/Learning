/*
 * @lc app=leetcode id=382 lang=csharp
 *
 * [382] Linked List Random Node
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

    public Solution(ListNode head) {
        random = new Random();
        this.head = head;
    }
    Random random;
    ListNode head;

    public int GetRandom() {
        int result = head.val;
        int i = 2;
        
        var node = head.next;
        while (node != null)
        {
            var r = random.Next(i);
            if (r == 0)
                result = node.val;
            i++;
            node = node.next;
        }
        return result;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.GetRandom();
 */
// @lc code=end

