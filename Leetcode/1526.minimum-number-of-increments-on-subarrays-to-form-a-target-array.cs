/*
 * @lc app=leetcode id=1526 lang=csharp
 *
 * [1526] Minimum Number of Increments on Subarrays to Form a Target Array
 */

// @lc code=start
public class Solution {
    public int MinNumberOperations(int[] target) {
        int result = target[0];
        for (int i = 1; i < target.Length; i++)
        {
            result += Math.Max(target[i] - target[i - 1], 0);
        }
        return result;
    }
}
// @lc code=end

