/*
 * @lc app=leetcode id=3396 lang=csharp
 *
 * [3396] Minimum Number of Operations to Make Elements in Array Distinct
 */

// @lc code=start
public class Solution {
    public int MinimumOperations(int[] nums) {
        bool[] seen = new bool[128];
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (seen[nums[i]])
            {
                return i / 3 + 1;
            }

            seen[nums[i]] = true;
        }

        return 0;
    }
}
// @lc code=end

