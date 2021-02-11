/*
 * @lc app=leetcode id=594 lang=csharp
 *
 * [594] Longest Harmonious Subsequence
 */

// @lc code=start
public class Solution {
    public int FindLHS(int[] nums) {
        var dict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (dict.ContainsKey(num))
                dict[num]++;
            else
                dict[num] = 1;
        }
        
        var result = 0;
        foreach (var entry in dict)
        {
            if (dict.TryGetValue(entry.Key + 1, out var count))
            {
                result = Math.Max(result, entry.Value + count);
            }
        }
        return result;
    }
}
// @lc code=end

