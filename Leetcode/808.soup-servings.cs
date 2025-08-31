/*
 * @lc app=leetcode id=808 lang=csharp
 *
 * [808] Soup Servings
 */

// @lc code=start
public class Solution {
    public double SoupServings(int n) {
        if (n > 4800)
        {
            return 1D;
        }
        
        double[,] dp = new double[200, 200];

        double serve(int a, int b)
        {
            if (a <= 0 && b <= 0)
            {
                return 0.5D;
            }
            else if (a <= 0)
            {
                return 1D;
            }
            else if (b <= 0)
            {
                return 0D;
            }

            if (dp[a, b] > 0D)
            {
                return dp[a, b];
            }

            dp[a, b] = 0.25D * (serve(a - 4, b) + serve(a - 3, b - 1) +
                serve(a - 2, b - 2) + serve(a - 1, b - 3));
            return dp[a, b];
        }
        
        return serve((n + 24) / 25, (n + 24) / 25);
    }
}
// @lc code=end

