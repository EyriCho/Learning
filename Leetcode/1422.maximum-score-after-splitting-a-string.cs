/*
 * @lc app=leetcode id=1422 lang=csharp
 *
 * [1422] Maximum Score After Splitting a String
 */

// @lc code=start
public class Solution {
    public int MaxScore(string s) {
        int max = -1,
            zero = 0,
            one = 0,
            last = s.Length - 1;

        for (int i = 0; i < last; i++)
        {
            if (s[i] == '0')
            {
                zero++;
            }
            else
            {
                one++;
            }

            max = Math.Max(max, zero - one);
        }

        if (s[last] == '1')
        {
            one++;
        }

        return max + one;
    }
}
// @lc code=end

