/*
 * @lc app=leetcode id=1688 lang=csharp
 *
 * [1688] Count of Matches in Tournament
 */

// @lc code=start
public class Solution {
    public int NumberOfMatches(int n) {
        if (n <= 1)
        {
            return 0;
        }

        return NumberOfMatches(n / 2 + ((n & 1) == 1 ? 1 : 0)) + n / 2;
    }
}
// @lc code=end

