/*
 * @lc app=leetcode id=377 lang=csharp
 *
 * [377] Combination Sum IV
 */

// @lc code=start
public class Solution {
    public int CombinationSum4(int[] nums, int target) {
        var counts = new int[target + 1];
        counts[0] = 1;
        
        for (int i = 0; i < target; i++)
        {
            foreach (var num in nums)
            {
                var next = i + num;
                if (next <= target)
                {
                    counts[next] += counts[i];
                }
            }
        }
        
        return counts[target];
    }
}
// @lc code=end

