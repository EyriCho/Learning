/*
 * @lc app=leetcode id=2270 lang=csharp
 *
 * [2270] Number of Ways to Split Array
 */

// @lc code=start
public class Solution {
    public int WaysToSplitArray(int[] nums) {
        long sum = 0L,
            temp = 0L;
        
        foreach (int num in nums)
        {
            sum += num; 
        }

        int result = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            temp += nums[i];
            if (temp >= sum - temp)
            {
                result++;
            }
        }

        return result;
    }
}
// @lc code=end

