/*
 * @lc app=leetcode id=1626 lang=csharp
 *
 * [1626] Best Team With No Conflicts
 */

// @lc code=start
public class Solution {
    public int BestTeamScore(int[] scores, int[] ages) {
        var array = new (int, int)[scores.Length];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = (ages[i], scores[i]);
        }

        Array.Sort(array, (a, b) =>
            a.Item1 == b.Item1 ? a.Item2 - b.Item2 : a.Item1 - b.Item1);

        int result = 0;
        var dp = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            dp[i] = array[i].Item2;
            for (int j = 0; j < i; j++)
            {
                if (array[j].Item2 <= array[i].Item2)
                {
                    dp[i] = Math.Max(dp[i], dp[j] + array[i].Item2);
                }
            }

            result = Math.Max(result, dp[i]);
        }
        return result;
    }
}
// @lc code=end

