/*
 * @lc app=leetcode id=215 lang=csharp
 *
 * [215] Kth Largest Element in an Array
 */

// @lc code=start
public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        return QuickFind(nums, 0, nums.Length - 1, k - 1);
    }
    
    private int QuickFind(int[] nums, int l, int r, int k)
    {
        if (l >= r)
            return nums[r];
        
        int m = l, temp = 0;
        for (int i = l + 1; i <= r; i++)
        {
            if (nums[i] > nums[l])
            {
                m++;
                temp = nums[m];
                nums[m] = nums[i];
                nums[i] = temp;
            }
        }
        temp = nums[m];
        nums[m] = nums[l];
        nums[l] = temp;
        
        if (m == k)
            return nums[m];
        else if (k > m)
            return QuickFind(nums, m + 1, r, k);
        else
            return QuickFind(nums, l, m - 1, k);
    }
}
// @lc code=end

