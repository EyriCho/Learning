/*
 * @lc app=leetcode id=23 lang=csharp
 *
 * [23] Merge k Sorted Lists
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
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists.Length == 0)
            return null;
        
        int step = 1;
        while (step < lists.Length)
        {
            for (int i = 0; i + step < lists.Length; i = i + step * 2)
                lists[i] = MergeTwoLists(lists[i], lists[i + step]);
            
            step *= 2;
        }
        
        
        return lists[0];
    }
    
    private ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null)
            return list2;
        if (list2 == null)
            return list1;
        
        ListNode fake = new ListNode();
        var node  = fake;
        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                node.next = list1;
                list1 = list1.next;
            }
            else
            {
                node.next = list2;
                list2 = list2.next;
            }
            node = node.next;
        }
        
        if (list1 != null)
            node.next = list1;
        if (list2 != null)
            node.next = list2;
        
        return fake.next;
    }
}
// @lc code=end

