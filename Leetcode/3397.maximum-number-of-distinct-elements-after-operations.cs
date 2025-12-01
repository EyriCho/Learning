/*
 * @lc app=leetcode id=3397 lang=csharp
 *
 * [3397] Maximum Number of Distinct Elements After Operations
 */

// @lc code=start
public class Solution {
    public int MaxDistinctElements(int[] nums, int k) {
        Array.Sort(nums);

        int prev = int.MinValue,
            current = 0,
            result = 0;
        foreach (int num in nums)
        {
            current = Math.Min(Math.Max(num - k, prev + 1), num + k);
            if (current > prev)
            {
                prev = current;
                result++;
            }
        }

        return result;
    }
}
// @lc code=end

