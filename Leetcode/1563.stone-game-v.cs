/*
 * @lc app=leetcode id=1563 lang=csharp
 *
 * [1563] Stone Game V
 */

// @lc code=start
public class Solution {
    public int StoneGameV(int[] stoneValue) {
        int[,] dp = new int[stoneValue.Length, stoneValue.Length],
            maxLeft = new int[stoneValue.Length, stoneValue.Length],
            maxRight = new int[stoneValue.Length, stoneValue.Length];

        int total = 0,
            sumLeft = 0,
            mid = 0;
        for (int left = stoneValue.Length - 1; left >= 0; left--)
        {
            maxLeft[left, left] = maxRight[left, left] = stoneValue[left];
            total = stoneValue[left];
            sumLeft = 0;
            mid = left - 1;

            for (int right = left + 1; right < stoneValue.Length; right++)
            {
                total += stoneValue[right];
                while (mid + 1 < right &&
                    (sumLeft + stoneValue[mid + 1]) * 2 <= total)
                {
                    sumLeft += stoneValue[mid + 1];
                    mid++;
                }

                if (left <= mid)
                {
                    dp[left, right] = Math.Max(dp[left, right],
                        maxLeft[left, mid]);
                }
                if (mid + 1 < right)
                {
                    dp[left, right] = Math.Max(dp[left, right],
                        maxRight[mid + 2, right]);
                }
                if (sumLeft * 2 == total)
                {
                    dp[left, right] = Math.Max(dp[left, right],
                        maxRight[mid + 1, right]);
                }

                maxLeft[left, right] = Math.Max(maxLeft[left, right - 1],
                    total + dp[left, right]);
                maxRight[left, right] = Math.Max(maxRight[left + 1, right],
                    total + dp[left, right]);
            }
        }

        return dp[0, stoneValue.Length - 1];
    }
}
// @lc code=end

