/*
 * @lc app=leetcode id=1402 lang=csharp
 *
 * [1402] Reducing Dishes
 */

// @lc code=start
public class Solution {
    public int MaxSatisfaction(int[] satisfaction) {
        Array.Sort(satisfaction, (a, b) => b - a);

        var result = 0;
        var cumulativeSum = 0;
        foreach (var s in satisfaction)
        {
            if (s + cumulativeSum > 0)
            {
                break;
            }

            result += cumulativeSum + s;
            cumulativeSum += s;
        }

        return result;
    }
}
// @lc code=end

