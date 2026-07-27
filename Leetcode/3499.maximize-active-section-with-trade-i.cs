/*
 * @lc app=leetcode id=3499 lang=csharp
 *
 * [3499] Maximize Active Section with Trade I
 */

// @lc code=start
public class Solution {
    public int MaxActiveSectionsAfterTrade(string s) {
        int ones = 0,
            prevZero = 0,
            currentZero = 0,
            trade = 0,
            i = 0;
        
        while (i < s.Length &&
            s[i] == '0')
        {
            i++;
        }
        prevZero = i;
        while (i < s.Length &&
            s[i] == '1')
        {
            ones++;
            i++;
        }

        while (i < s.Length)
        {
            currentZero = 0;
            while (i < s.Length &&
                s[i] == '0')
            {
                i++;
                currentZero++;
            }
            if (prevZero > 0 && currentZero > 0)
            {
                trade = Math.Max(trade, prevZero + currentZero);
            }
            prevZero = currentZero;

            while (i < s.Length &&
                s[i] == '1')
            {
                i++;
                ones++;
            }
        }

        return ones + trade;
    }
}
// @lc code=end

