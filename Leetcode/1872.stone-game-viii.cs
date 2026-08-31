/*
 * @lc app=leetcode id=1872 lang=csharp
 *
 * [1872] Stone Game VIII
 */

// @lc code=start
public class Solution {
    public int StoneGameVIII(int[] stones) {
        for (int i = 1; i < stones.Length; i++)
        {
            stones[i] += stones[i - 1];
        }

        int best = stones[^1];
        for (int i = stones.Length - 2; i > 0; i--)
        {
            best = Math.Max(best, stones[i] - best);
        }

        return best;
    }
}
// @lc code=end

