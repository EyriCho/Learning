/*
 * @lc app=leetcode id=1218 lang=csharp
 *
 * [1218] Longest Arithmetic Subsequence of Given Difference
 */

// @lc code=start
public class Solution {
    public int LongestSubsequence(int[] arr, int difference) {
        var dict = new Dictionary<int, int>();
        var max = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            var p = arr[i] - difference;
            dict.TryGetValue(p, out int prevCount);
            max = Math.Max(max, dict[arr[i]] = prevCount + 1);
        }

        return max;
    }
}
// @lc code=end

