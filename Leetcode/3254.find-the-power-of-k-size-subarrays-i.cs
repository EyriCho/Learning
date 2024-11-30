/*
 * @lc app=leetcode id=3254 lang=csharp
 *
 * [3254] Find the Power of K-Size Subarrays I 
 */

// @lc code=start
public class Solution {
    public int[] ResultsArray(int[] nums, int k) {
        int[] result = new int[nums.Length - k + 1];
        Array.Fill(result, -1);

        if (k == 1)
        {
            result[0] = nums[0];
        }
        int count = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1] + 1)
            {
                count++;
            }
            else
            {
                count = 1;
            }

            if (count >= k)
            {
                result[i - k + 1] = nums[i];
            }
        }

        return result;
    }
}
// @lc code=end

