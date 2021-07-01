/*
 * @lc app=leetcode id=128 lang=csharp
 *
 * [128] Longest Consecutive Sequence
 */

// @lc code=start
public class Solution {
    public int LongestConsecutive(int[] nums) {
        var dict = new Dictionary<int, bool>();
        foreach (var num in nums)
            dict[num] = false;
        
        var result = 0;
        foreach (var num in nums)
        {
            if (dict[num])
                continue;
            
            dict[num] = true;
            int low = num - 1, high = num + 1;
            while (dict.ContainsKey(low))
                dict[low--] = true;
            while (dict.ContainsKey(high))
                dict[high++] = true;
            result = Math.Max(result, high - low - 1);
        }
        
        return result;
    }
}
// @lc code=end

