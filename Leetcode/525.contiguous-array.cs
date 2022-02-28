/*
 * @lc app=leetcode id=525 lang=csharp
 *
 * [525] Contiguous Array
 */

// @lc code=start
public class Solution {
    public int FindMaxLength(int[] nums) {
        int total = 0, result = 0;
        var dict = new Dictionary<int, int>();
        dict[0] = -1;
        
        for (int i = 0; i < nums.Length; i++)
        {
            total += nums[i] > 0 ? 1 : -1;
            
            if (dict.ContainsKey(total))
            {
                result = Math.Max(result, i - dict[total]);
            }
            else
            {
                dict[total] = i;
            }
        }
        
        return result;
    }
}
// @lc code=end

