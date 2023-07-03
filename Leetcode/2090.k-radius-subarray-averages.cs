/*
 * @lc app=leetcode id=2090 lang=csharp
 *
 * [2090] K Radius Subarray Averages
 */

// @lc code=start
public class Solution {
    public int[] GetAverages(int[] nums, int k) {
        var result = new int[nums.Length];
        Array.Fill(result, -1);

        int i = 0,
            count = k * 2 + 1,
            last = nums.Length - k;
        long sum = 0L;
        
        if (nums.Length < count)
        {
            return result;
        }

        while (i < count)
        {
            sum += nums[i++];
        }
        result[i - 1 - k] = (int)(sum / count);

        while (i < nums.Length)
        {
            sum += nums[i] - nums[i - count];
            result[i - k] = (int)(sum / count);
            i++;
        }

        return result;
    }
}
// @lc code=end

