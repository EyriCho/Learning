/*
 * @lc app=leetcode id=565 lang=csharp
 *
 * [565] Array Nesting
 */

// @lc code=start
public class Solution {
    public int ArrayNesting(int[] nums) {
        var dp = new int[nums.Length];
        
        int Nest(HashSet<int> set, int i)
        {
            if (dp[i] != 0)
                return dp[i];
            
            if (set.Contains(i))
                return 0;
            else
            {
                set.Add(i);
                dp[i] = Nest(set, nums[i]) + 1;
                return dp[i];
            }
        }
        
        var result = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (dp[i] == 0)
                result = Math.Max(result, Nest(new HashSet<int>(), i));
        }
        
        return result;
    }
}
// @lc code=end

