/*
 * @lc app=leetcode id=3737 lang=csharp
 *
 * [3737] Count Subarrays With Majority Element I
 */

// @lc code=start
public class Solution {
    public int CountMajoritySubarrays(int[] nums, int target) {
        int count = 0,
            result = 0;
        
        for (int r = 0; r < nums.Length; r++)
        {
            count = 0;
            for (int l = r; l >= 0; l--)
            {
                count += nums[l] == target ? 1 : -1;

                if (count > 0)
                {
                    result++;
                }
            }
        }

        return result;
    }
}
// @lc code=end

