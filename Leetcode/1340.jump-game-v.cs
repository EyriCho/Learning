/*
 * @lc app=leetcode id=1340 lang=csharp
 *
 * [1340] Jump Game V
 */

// @lc code=start
public class Solution {
    public int MaxJumps(int[] arr, int d) {
        int[] dp = new int[arr.Length];
        Array.Fill(dp, -1);

        void Dfs(int pos)
        {
            if (dp[pos] != -1)
            {
                return;
            }
            
            int max = 0;
            for (int l = pos - 1; l >= 0 && pos - l <= d && arr[pos] > arr[l]; l--)
            {
                Dfs(l);
                max = Math.Max(dp[l], max);
            }

            for (int r = pos + 1; r < arr.Length && r - pos <= d && arr[pos] > arr[r]; r++)
            {
                Dfs(r);
                max = Math.Max(dp[r], max);
            }
            dp[pos] = max + 1;
        }
        
        int result = 1;
        for (int p = 0; p < arr.Length; p++)
        {
            Dfs(p);

            result = Math.Max(dp[p], result);
        }

        return result;
    }
}
// @lc code=end

