/*
 * @lc app=leetcode id=2938 lang=csharp
 *
 * [2938] Seperate Black and White Balls
 */

// @lc code=start
public class Solution {
    public long MinimumSteps(string s) {
        int l = 0,
            r = s.Length - 1;
        long result = 0L;

        while (l < r)
        {
            while (l < r &&
                s[l] == '0')
            {
                l++;
            }

            while (l < r &&
                s[r] == '1')
            {
                r--;
            }

            if (l >= r)
            {
                break;
            }

            result += r - l;
            l++;
            r--;
        }

        return result;
    }
}
// @lc code=end

