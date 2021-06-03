/*
 * @lc app=leetcode id=34 lang=csharp
 *
 * [34] Find First and Last Position of Element in Sorted Array
 */

// @lc code=start
public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        if (nums.Length == 0)
            return new int[] { -1, -1 };
            
        var result = new int[] {
            nums.Length, 0
        };
        
        void BinarySearch(int l, int r)
        {
            if (l > r)
                return;
            
            var m = (l + r) / 2;
            if (nums[m] == target)
            {
                result[0] = Math.Min(m, result[0]);
                result[1] = Math.Max(m, result[1]);
                BinarySearch(l, m - 1);
                BinarySearch(m + 1, r);
            }
            else if (nums[m] > target)
                BinarySearch(l, m - 1);
            else
                BinarySearch(m + 1, r);
        }
        
        BinarySearch(0, nums.Length - 1);
        if (result[0] > result[1])
            result[0] = result[1] = -1;
        
        return result;
    }
}
// @lc code=end

