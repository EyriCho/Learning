/*
 * @lc app=leetcode id=25 lang=csharp
 *
 * [25] Reverse Nodes in k-Group
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
    public ListNode ReverseKGroup(ListNode head, int k) {
        var fake = new ListNode(0, head);
        ListNode prev = fake,
            node = head;
        
        while (node != null)
        {
            int c = 1;
            var seg = node;
            while (seg != null && c++ < k)
                seg = seg.next;
            if (seg == null)
                break;
            
            var nextSeg = seg.next;
            var nextPrev = node;
            seg = node;
            ListNode n = seg, p = nextSeg;
            while (seg != nextSeg)
            {
                n = seg.next;
                seg.next = p;
                p = seg;
                seg = n;
            }
            
            prev.next = p;
            prev = nextPrev;
            node = nextSeg;
        }
        
        return fake.next;
    }
}
// @lc code=end

