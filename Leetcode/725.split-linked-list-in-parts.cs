/*
 * @lc app=leetcode id=725 lang=csharp
 *
 * [725] Split Linked List in Parts
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
    public ListNode[] SplitListToParts(ListNode head, int k) {
        int sum = 0;
        foreach (var num in nums)
            sum += num;
        if (sum % k > 0)
            return false;
        
        
        Array.Sort(nums, (a, b) => b - a);
        var average = sum / k;
        if (nums[0] > average)
            return false;
        
        var partitions = new int[k];
        Array.Fill(partitions, average);
        bool Dfs(int index)
        {
            if (index == nums.Length)
                return true;
            
            for (int i = 0; i < partitions.Length; i++)
            {
                if (partitions[i] > 0 && partitions[i] >= nums[index])
                {
                    partitions[i] -= nums[index];
                    
                    if (Dfs(index + 1))
                        return true;
                    
                    partitions[i] += nums[index];
                }
            }
            return false;
        }
        
        return Dfs(0);
    }
}
// @lc code=end

