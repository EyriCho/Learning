/*
 * @lc app=leetcode id=594 lang=csharp
 *
 * [594] Longest Harmonious Subsequence
 */

// @lc code=start
public class Solution {
    public int FindLHS(int[] nums) {
        Array.Sort(nums);
        int l = 0, r = 0, temp = 0,
            result = 0;
        
        while (r < nums.Length)
        {
            temp = r;
            while (r < nums.Length && nums[r] == nums[temp])
            {
                r++;
            }
            if (nums[temp] - nums[l] == 1)
            {
                result = Math.Max(result, r - l);
            }
            l = temp;
        }
        return result;
    }
}
// @lc code=end

