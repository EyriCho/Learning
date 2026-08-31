/*
 * @lc app=leetcode id=1927 lang=csharp
 *
 * [1927] Sum Game
 */

// @lc code=start
public class Solution {
    public bool SumGame(string num) {
        int left = 0,
            right = 0,
            half = num.Length >> 1,
            qLeft = 0,
            qRight = 0;

        for (int i = 0; i < half; i++)
        {
            if (num[i] == '?')
            {
                qLeft++;
            }
            else
            {
                left += num[i] - '0';
            }

            if (num[i + half] == '?')
            {
                qRight++;
            }
            else
            {
                right += num[i + half] - '0';
            }
        }

        if (((qLeft + qRight) & 1) == 1)
        {
            return true;
        }

        int diff = left - right,
            qDiff = qRight - qLeft;
        
        return diff != (qDiff >> 1) * 9;
    }
}
// @lc code=end

