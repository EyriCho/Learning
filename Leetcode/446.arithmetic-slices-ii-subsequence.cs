/*
 * @lc app=leetcode id=446 lang=csharp
 *
 * [446] Arithmetic Slices II - Subsequence
 */

// @lc code=start
public class Solution {
    public int NumberOfArithmeticSlices(int[] nums) {
        int result = 0;
        Dictionary<int, int>[] dp = new Dictionary<int, int>[nums.Length];
        
        for (int i = 0; i < nums.Length; i++)
        {
            dp[i] = new ();
            for (int j = 0; j < i; j++)
            {
                long diff = (long)nums[i] - nums[j];
                if (diff >= int.MaxValue || diff <= int.MinValue)
                {
                    continue;
                }
                int d = (int)diff;
                dp[i].TryGetValue(d, out int countI);
                dp[j].TryGetValue(d, out int countJ);
                dp[i][d] = countI + countJ + 1;
                result += countJ;
            }
        }
        
        return result;
    }
}
// @lc code=end

