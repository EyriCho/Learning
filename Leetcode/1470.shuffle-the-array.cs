/*
 * @lc app=leetcode id=1470 lang=csharp
 *
 * [1470] Shuffle the Array
 */

// @lc code=start
public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        var result = new int[n * 2];

        for (int i = 0; i < n; i++)
        {
            result[i * 2] = nums[i];
            result[i * 2 + 1] = nums[i + n];
        }

        return result;
    }
}
// @lc code=end

