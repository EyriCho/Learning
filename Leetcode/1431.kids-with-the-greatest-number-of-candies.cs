/*
 * @lc app=leetcode id=1431 lang=csharp
 *
 * [1431] Kids With the Greatest Number of Candies
 */

// @lc code=start
public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        var result = new bool[candies.Length];

        var max = candies[0];
        for (int i = 1; i < candies.Length; i++)
        {
            max = Math.Max(candies[i], max);
        }

        max -= extraCandies;
        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] >= max)
            {
                result[i] = true;
            }
        }

        return result;
    }
}
// @lc code=end

